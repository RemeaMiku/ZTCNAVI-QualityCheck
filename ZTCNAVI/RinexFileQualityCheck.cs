using System;
using System.Text;
using static System.Math;
using static ZTCNAVI.Algo;

namespace ZTCNAVI
{
    internal class RinexFileQualityCheck
    {
        /// <summary>
        /// 无周跳观测总数
        /// </summary>
        private int _noneSlipCount;

        /// <summary>
        /// 有效双频观测总数
        /// </summary>
        private int _validDualFrequencyObservationsCount;

        public RinexFileQualityCheck(RinexFile rinexFile)
        {
            RinexFile = rinexFile;
            int epochNum = rinexFile.FileDataRecord.Count;
            int prnNum = rinexFile.PrnsOfGPSAndBDS.Count;
            DataIntegrityOfGPS = new float[3];
            DataIntegrityOfBDS = new float[4];
            SlipDetectionOfEpochs = new int[epochNum, prnNum];
            MultipathsAtF1 = new double[epochNum, prnNum];
            MultipathsAtF2 = new double[epochNum, prnNum];
            MultipathRMSOfSatellitesAtF1 = new float[prnNum];
            MultipathRMSOfSatellitesAtF2 = new float[prnNum];
            CheckTime = DateTime.Now;
            SetDataIntegrityOfGPSAndBDS();
            SetSlipDetectionOfSatellites();
            SetMultipathsOfSatellites();
        }

        public DateTime CheckTime { get; set; }

        /// <summary>
        /// BDS数据完整率表
        /// 0:All
        /// 1:B1
        /// 2:B2
        /// 3:B3
        /// </summary>
        public float[] DataIntegrityOfBDS { get; }

        /// <summary>
        /// GPS数据完整率表
        /// 0:All
        /// 1:L1
        /// 2:L2
        /// </summary>
        public float[] DataIntegrityOfGPS { get; }

        /// <summary>
        /// 卫星数据完整率表
        /// 索引是[PRN]
        /// </summary>
        public DataIntegrityOfSatellite[] DataIntegrityOfSatellites
        {
            get
            {
                return GetDataIntegrityOfSatellites();
            }
        }

        public string FileName
        {
            get
            {
                return $"{RinexFile.FileName}.qc";
            }
        }

        /// <summary>
        /// F1多路径的总RMS
        /// </summary>
        public float MultipathRMSAtF1
        {
            get
            {
                return GetMultipathRMSAtL1OrB1();
            }
        }

        /// <summary>
        /// F2多路径的总RMS
        /// </summary>
        public float MultipathRMSAtF2
        {
            get
            {
                return GetMultipathRMSAtL2OrB2();
            }
        }

        /// <summary>
        /// 卫星F1多路径RMS表
        /// 索引是[PRN]
        /// </summary>
        public float[] MultipathRMSOfSatellitesAtF1 { get; }

        /// <summary>
        /// 卫星F2多路径RMS表
        /// 索引是[PRN]
        /// </summary>
        public float[] MultipathRMSOfSatellitesAtF2 { get; }

        /// <summary>
        /// F1多路径表
        /// 索引是[历元][PRN]
        /// </summary>
        public double[,] MultipathsAtF1 { get; }

        /// <summary>
        /// F2多路径表
        /// 索引是[历元][PRN]
        /// </summary>
        public double[,] MultipathsAtF2 { get; }

        /// <summary>
        /// 总无周跳比
        /// </summary>
        public float NoneSlipRatio
        {
            get
            {
                return (float)_noneSlipCount / _validDualFrequencyObservationsCount;
            }
        }

        /// <summary>
        /// 检核的Rinex文件
        /// </summary>
        public RinexFile RinexFile { get; }

        /// <summary>
        /// 历元周跳探测表
        /// 索引是[历元][PRN]
        /// 0：正常
        /// 1：周跳
        /// -1：无值
        /// </summary>
        public int[,] SlipDetectionOfEpochs { get; }

        /// <summary>
        /// 卫星周跳探测表
        /// 索引是[PRN]
        /// </summary>
        public SlipDetectionOfSatellite[] SlipDetectionOfSatellites
        {
            get
            {
                return GetSlipDetectionOfSatellites();
            }
        }

        public string ToDocumentText()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"{RinexFile.FileName}质检报告：ZTCNAVI");
            builder.AppendLine($"检核时间：{CheckTime.ToString("F")}");
            builder.AppendLine("卫星系统\t完整率");
            builder.AppendLine($"GPS系统\tAll:{DataIntegrityOfGPS[0]}\tL1:{DataIntegrityOfGPS[1]}\tL2:{DataIntegrityOfGPS[2]}");
            builder.AppendLine($"BDS系统\tAll:{DataIntegrityOfBDS[0]}\tB1:{DataIntegrityOfBDS[1]}\tB2:{DataIntegrityOfBDS[2]}\tB3:{DataIntegrityOfBDS[3]}");
            builder.AppendLine($"总无周跳比:{NoneSlipRatio}");
            builder.AppendLine($"F1 MPRMS:{MultipathRMSAtF1}\tF2 MPRMS:{MultipathRMSAtF2}");
            builder.AppendLine("==============================================");
            builder.AppendLine("观测数据完整度：");

            builder.AppendLine("卫星号\tL1/B1\tL2/B2\tB3\tAll\t理论");
            foreach (var dI in DataIntegrityOfSatellites)
            {
                builder.AppendLine($"{dI.PRN}\t{dI.ActualEpochCountAtL1OrB1}\t{dI.ActualEpochCountAtL2OrB2}\t{dI.ActualEpochCountAtB3}\t{dI.ActualEpochAtAll}\t{dI.TheoreticalEpochCount}");
            }
            builder.AppendLine();
            builder.AppendLine("周跳探测：");

            builder.AppendLine("历元表 0=无周跳；1=周跳；-1=无观测值");
            builder.Append("历元");
            for (int satelliteIndex = 0; satelliteIndex < RinexFile.PrnsOfGPSAndBDS.Count; satelliteIndex++)
            {
                builder.Append($"\t{RinexFile.PrnsOfGPSAndBDS[satelliteIndex]}");
            }
            builder.AppendLine();
            for (int epochIndex = 0; epochIndex < RinexFile.FileDataRecord.Count; epochIndex++)
            {
                builder.Append(RinexFile.FileDataRecord[epochIndex].DateTime.ToString("F"));
                for (int satelliteIndex = 0; satelliteIndex < RinexFile.PrnsOfGPSAndBDS.Count; satelliteIndex++)
                {
                    builder.Append($"\t{SlipDetectionOfEpochs[epochIndex, satelliteIndex]}");
                }
                builder.AppendLine();
            }
            builder.AppendLine("卫星号\t观测数\t周跳数\t无周跳比");
            for (int i = 0; i < RinexFile.PrnsOfGPSAndBDS.Count; i++)
            {
                var s = SlipDetectionOfSatellites[i];
                builder.AppendLine($"{s.PRN}\t{s.ValidDualFrequencyObservationsCount}\t{s.SlipCount}\t{s.NoneSlipRatio}");
            }
            builder.AppendLine();
            builder.AppendLine("多路径效应:");

            builder.Append("历元");
            for (int satelliteIndex = 0; satelliteIndex < RinexFile.PrnsOfGPSAndBDS.Count; satelliteIndex++)
            {
                builder.Append($"\t{RinexFile.PrnsOfGPSAndBDS[satelliteIndex]}:MP1\t{RinexFile.PrnsOfGPSAndBDS[satelliteIndex]}:MP2");
            }
            builder.AppendLine();
            for (int epochIndex = 0; epochIndex < RinexFile.FileDataRecord.Count; epochIndex++)
            {
                builder.Append(RinexFile.FileDataRecord[epochIndex].DateTime.ToString("F"));
                for (int satelliteIndex = 0; satelliteIndex < RinexFile.PrnsOfGPSAndBDS.Count; satelliteIndex++)
                {
                    builder.Append($"\t{MultipathsAtF1[epochIndex, satelliteIndex]}\t{MultipathsAtF2[epochIndex, satelliteIndex]}");
                }
                builder.AppendLine();
            }
            builder.AppendLine("卫星号\tMP1 RMS\tMP2 RMS");
            for (int i = 0; i < RinexFile.PrnsOfGPSAndBDS.Count; i++)
            {
                builder.AppendLine($"{RinexFile.PrnsOfGPSAndBDS[i]}\t{MultipathRMSOfSatellitesAtF1[i]}\t{MultipathRMSOfSatellitesAtF2[i]}");
            }
            return builder.ToString();
        }

        private DataIntegrityOfSatellite[] GetDataIntegrityOfSatellites()
        {
            int satelliteNum = RinexFile.PrnsOfGPSAndBDS.Count;
            DataIntegrityOfSatellite[] dataIntegrityOfSatellites = new DataIntegrityOfSatellite[satelliteNum];
            int[] startEpochIndexes = new int[satelliteNum];
            int[] endEpochIndexes = new int[satelliteNum];
            for (int i = 0; i < satelliteNum; i++)
            {
                dataIntegrityOfSatellites[i] = new DataIntegrityOfSatellite(RinexFile.PrnsOfGPSAndBDS[i]);
                startEpochIndexes[i] = -1;
                endEpochIndexes[i] = 0;
            }
            foreach (RinexFileDataRecord record in RinexFile.FileDataRecord)
            {
                int epochIndex = RinexFile.FileDataRecord.IndexOf(record);
                foreach (ObservationsOfSatellite obs in record.ObservationsOfSatellites)
                {
                    bool haveAll = true;
                    int satelliteIndex = RinexFile.PrnsOfGPSAndBDS.IndexOf(obs.PRNOfSatellite);
                    RinexFile.GetTypeOfF1(obs.TypeOfSatellite, out string C1type, out string L1type);
                    RinexFile.GetTypeOfF2(obs.TypeOfSatellite, out string C2type, out string L2type);
                    RinexFile.GetTypeOfF3(obs.TypeOfSatellite, out string C3type, out string L3type);
                    if (startEpochIndexes[satelliteIndex] == -1)
                    {
                        startEpochIndexes[satelliteIndex] = epochIndex;
                    }
                    endEpochIndexes[satelliteIndex] = epochIndex;
                    if (!double.IsNaN(obs[C1type]) && !double.IsNaN(obs[L1type]))
                    {
                        dataIntegrityOfSatellites[satelliteIndex].ActualEpochCountAtL1OrB1++;
                    }
                    else
                    {
                        if (C1type != null && L1type != null)
                        {
                            haveAll = false;
                        }
                    }
                    if (!double.IsNaN(obs[C2type]) && !double.IsNaN(obs[L2type]))
                    {
                        dataIntegrityOfSatellites[satelliteIndex].ActualEpochCountAtL2OrB2++;
                    }
                    else
                    {
                        if (C2type != null && L2type != null)
                        {
                            haveAll = false;
                        }
                    }
                    if (!double.IsNaN(obs[C3type]) && !double.IsNaN(obs[L3type]))
                    {
                        dataIntegrityOfSatellites[satelliteIndex].ActualEpochCountAtB3++;
                    }
                    else
                    {
                        if (C3type != null && C3type != null)
                        {
                            haveAll = false;
                        }
                    }
                    if (haveAll)
                    {
                        dataIntegrityOfSatellites[satelliteIndex].ActualEpochAtAll++;
                    }
                }
            }
            for (int i = 0; i < satelliteNum; i++)
            {
                dataIntegrityOfSatellites[i].TheoreticalEpochCount = endEpochIndexes[i] - startEpochIndexes[i] + 1;
            }
            return dataIntegrityOfSatellites;
        }

        private float GetMultipathRMSAtL1OrB1()
        {
            double sum = 0;
            foreach (var MP1 in MultipathsAtF1)
            {
                sum += Pow(MP1, 2);
            }
            return (float)Sqrt(sum / _validDualFrequencyObservationsCount);
        }

        private float GetMultipathRMSAtL2OrB2()
        {
            double sum = 0;
            foreach (var MP2 in MultipathsAtF2)
            {
                sum += Pow(MP2, 2);
            }
            return (float)Sqrt(sum / _validDualFrequencyObservationsCount);
        }

        private SlipDetectionOfSatellite[] GetSlipDetectionOfSatellites()
        {
            var slipDetectionOfSatellites = new SlipDetectionOfSatellite[RinexFile.PrnsOfGPSAndBDS.Count];
            for (int prnIndex = 0; prnIndex < RinexFile.PrnsOfGPSAndBDS.Count; prnIndex++)
            {
                SlipDetectionOfSatellite sD = new SlipDetectionOfSatellite(RinexFile.PrnsOfGPSAndBDS[prnIndex]);
                for (int epochIndex = 0; epochIndex < RinexFile.FileDataRecord.Count; epochIndex++)
                {
                    switch (SlipDetectionOfEpochs[epochIndex, prnIndex])
                    {
                        case 0:
                            sD.ValidDualFrequencyObservationsCount++;
                            break;

                        case 1:
                            sD.SlipCount++;
                            sD.ValidDualFrequencyObservationsCount++;
                            break;

                        case -1:
                            break;

                        default:
                            break;
                    }
                }
                slipDetectionOfSatellites[prnIndex] = sD;
            }
            return slipDetectionOfSatellites;
        }

        private void SetDataIntegrityOfGPSAndBDS()
        {
            int actualEpochSumAtL1 = 0, actualEpochSumAtL2 = 0, actualEpochSumAtB1 = 0, actualEpochSumAtB2 = 0, actualEpochSumAtB3 = 0,
                actualEpochSumOfGPS = 0, actualEpochSumOfBDS = 0,
                theoreticalEpochSumOfGPS = 0, theoreticalEpochSumOfBDS = 0;
            foreach (DataIntegrityOfSatellite dataIntegrityOfSatellite in DataIntegrityOfSatellites)
            {
                if (dataIntegrityOfSatellite.SatelliteSystemType == SatelliteSystemType.GPS)
                {
                    actualEpochSumAtL1 += dataIntegrityOfSatellite.ActualEpochCountAtL1OrB1;
                    actualEpochSumAtL2 += dataIntegrityOfSatellite.ActualEpochCountAtL2OrB2;
                    actualEpochSumOfGPS += dataIntegrityOfSatellite.ActualEpochAtAll;
                    theoreticalEpochSumOfGPS += dataIntegrityOfSatellite.TheoreticalEpochCount;
                }
                else
                {
                    actualEpochSumAtB1 += dataIntegrityOfSatellite.ActualEpochCountAtL1OrB1;
                    actualEpochSumAtB2 += dataIntegrityOfSatellite.ActualEpochCountAtL2OrB2;
                    actualEpochSumAtB3 += dataIntegrityOfSatellite.ActualEpochCountAtB3;
                    actualEpochSumOfBDS += dataIntegrityOfSatellite.ActualEpochAtAll;
                    theoreticalEpochSumOfBDS += dataIntegrityOfSatellite.TheoreticalEpochCount;
                }
            }
            DataIntegrityOfGPS[0] = (float)actualEpochSumOfGPS / theoreticalEpochSumOfGPS;
            DataIntegrityOfGPS[1] = (float)actualEpochSumAtL1 / theoreticalEpochSumOfGPS;
            DataIntegrityOfGPS[2] = (float)actualEpochSumAtL2 / theoreticalEpochSumOfGPS;
            DataIntegrityOfBDS[0] = (float)actualEpochSumOfBDS / theoreticalEpochSumOfBDS;
            DataIntegrityOfBDS[1] = (float)actualEpochSumAtB1 / theoreticalEpochSumOfBDS;
            DataIntegrityOfBDS[2] = (float)actualEpochSumAtB2 / theoreticalEpochSumOfBDS;
            DataIntegrityOfBDS[3] = (float)actualEpochSumAtB3 / theoreticalEpochSumOfBDS;
        }

        private void SetMultipathsOfSatellites()
        {
            int epochNum = RinexFile.FileDataRecord.Count;
            int prnNum = RinexFile.PrnsOfGPSAndBDS.Count;
            for (int prnIndex = 0; prnIndex < prnNum; prnIndex++)
            {
                int startEpochIndex = 0, endEpochIndex;
                double sumMP1 = 0, sumMP2 = 0, sumMP1_2 = 0, sumMP2_2 = 0;
                for (int epochIndex = 0; epochIndex < epochNum; epochIndex++)
                {
                    int slipDetection = SlipDetectionOfEpochs[epochIndex, prnIndex];
                    if (slipDetection == 0 && epochIndex != epochNum - 1)
                    {
                        string prn = RinexFile.PrnsOfGPSAndBDS[prnIndex];
                        SatelliteSystemType type = (SatelliteSystemType)prn[0];
                        ObservationsOfSatellite obs = RinexFile.FileDataRecord[epochIndex][prn];
                        GetMP(out double MP1, out double MP2, type, obs.GetPseudoRangeAndPhaseAtF1F2());
                        MultipathsAtF1[epochIndex, prnIndex] = MP1;
                        MultipathsAtF2[epochIndex, prnIndex] = MP2;
                        sumMP1 += MP1;
                        sumMP2 += MP2;
                    }
                    else
                    {
                        endEpochIndex = epochIndex;
                        int num = endEpochIndex - startEpochIndex;
                        double meanMP1 = sumMP1 / num, meanMP2 = sumMP2 / num;
                        for (int i = startEpochIndex; i < endEpochIndex; i++)
                        {
                            MultipathsAtF1[i, prnIndex] -= meanMP1;
                            MultipathsAtF2[i, prnIndex] -= meanMP2;
                            sumMP1_2 += Pow(MultipathsAtF1[i, prnIndex], 2);
                            sumMP2_2 += Pow(MultipathsAtF2[i, prnIndex], 2);
                        }
                        startEpochIndex = endEpochIndex + 1;
                        sumMP1 = 0;
                        sumMP2 = 0;
                    }
                }
                MultipathRMSOfSatellitesAtF1[prnIndex] = (float)Sqrt(sumMP1_2 / SlipDetectionOfSatellites[prnIndex].ValidDualFrequencyObservationsCount);
                MultipathRMSOfSatellitesAtF2[prnIndex] = (float)Sqrt(sumMP2_2 / SlipDetectionOfSatellites[prnIndex].ValidDualFrequencyObservationsCount);
            }
        }

        private void SetSlipDetectionOfSatellites()
        {
            _validDualFrequencyObservationsCount = 0;
            _noneSlipCount = 0;
            double[] lastMWs = new double[RinexFile.PrnsOfGPSAndBDS.Count];
            double[] lastGFs = new double[RinexFile.PrnsOfGPSAndBDS.Count];
            foreach (RinexFileDataRecord rinexFileDataRecord in RinexFile.FileDataRecord)
            {
                int epochIndex = RinexFile.FileDataRecord.IndexOf(rinexFileDataRecord);
                foreach (string prn in RinexFile.PrnsOfGPSAndBDS)
                {
                    int prnIndex = RinexFile.PrnsOfGPSAndBDS.IndexOf(prn);
                    SatelliteSystemType type = (SatelliteSystemType)prn[0];
                    double MW = double.NaN, GF = double.NaN;
                    Data.GetF1F2(type, out double f1, out double f2);
                    ObservationsOfSatellite obs = rinexFileDataRecord[prn];
                    if (obs != null)
                    {
                        GetMWAndGF(out MW, out GF, type, obs.GetPseudoRangeAndPhaseAtF1F2());
                        if (!double.IsNaN(MW))
                        {
                            _validDualFrequencyObservationsCount++;
                            if (epochIndex != 0)
                            {
                                if (Abs(MW - lastMWs[prnIndex]) * (f1 - f2) / Data.c < Data.MWThreshold && Abs(GF - lastGFs[prnIndex]) < Data.GFThreshold)
                                {
                                    SlipDetectionOfEpochs[epochIndex, prnIndex] = 0;
                                    _noneSlipCount++;
                                }
                                else
                                {
                                    SlipDetectionOfEpochs[epochIndex, prnIndex] = 1;
                                }
                            }
                            else
                            {
                                SlipDetectionOfEpochs[epochIndex, prnIndex] = 0;
                            }
                        }
                        else
                        {
                            SlipDetectionOfEpochs[epochIndex, prnIndex] = -1;
                        }
                    }
                    else
                    {
                        SlipDetectionOfEpochs[epochIndex, prnIndex] = -1;
                    }
                    lastMWs[prnIndex] = MW;
                    lastGFs[prnIndex] = GF;
                }
            }
        }
    }
}