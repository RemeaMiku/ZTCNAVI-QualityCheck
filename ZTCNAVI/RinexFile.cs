using System;
using System.Collections.Generic;
using System.IO;

namespace ZTCNAVI
{
    /// <summary>
    /// Rinex文件类
    /// </summary>
    internal class RinexFile
    {
        private readonly List<string> _allPrnsOfGPSAndBDS;
        private readonly List<string> _allTypesOfBDSObs;
        private readonly List<string> _allTypesOfGPSObs;
        private readonly List<RinexFileComment> _comments;
        private readonly List<RinexFileDataRecord> _dataRecord;
        private readonly StreamReader _sr;

        public RinexFile(string fileName, StreamReader sr)
        {
            FileName = fileName;
            _comments = new List<RinexFileComment>();
            _dataRecord = new List<RinexFileDataRecord>();
            _allTypesOfBDSObs = new List<string>();
            _allTypesOfGPSObs = new List<string>();
            _sr = sr;
            _allPrnsOfGPSAndBDS = new List<string>();
            SetRinexFile();
        }

        /// <summary>
        /// Rinex文件注释
        /// </summary>
        public List<RinexFileComment> FileComments
        {
            get
            {
                return _comments;
            }
        }

        /// <summary>
        /// Rinex文件数据记录
        /// </summary>
        public List<RinexFileDataRecord> FileDataRecord
        {
            get
            {
                return _dataRecord;
            }
        }

        public string FileName { get; set; }

        /// <summary>
        /// 所有GPS和BDS卫星的PRN号
        /// </summary>
        public List<string> PrnsOfGPSAndBDS
        {
            get
            {
                return _allPrnsOfGPSAndBDS;
            }
        }

        /// <summary>
        /// 获取卫星系统的所有观测值类型
        /// </summary>
        /// <param name="systemType"></param>
        /// <returns></returns>
        public List<string> GetAllTypesOfSatelliteSystemObservations(SatelliteSystemType systemType)
        {
            if (systemType == SatelliteSystemType.GPS) return _allTypesOfGPSObs;
            if (systemType == SatelliteSystemType.BDS) return _allTypesOfBDSObs;
            return null;
        }

        /// <summary>
        /// 获得指定标签的注释内容
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public string GetCommentOf(string label)
        {
            try
            {
                return _comments.Find(t => t.Label.Contains(label)).Comment;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 获得指定标签的注释行
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public List<string> GetCommentsOf(string label)
        {
            RinexFileComment rinexFileComment = _comments.Find(t => t.Label.Contains(label));
            if (rinexFileComment != null)
            {
                return rinexFileComment.Comments;
            }
            else
            {
                return null;
            }
        }

        public void GetTypeOfF1(SatelliteSystemType type, out string typeOfPseudorange, out string typeOfPhase)
        {
            if (type == SatelliteSystemType.GPS)
            {
                typeOfPseudorange = _allTypesOfGPSObs.Find(t => t.Contains("C1"));
                typeOfPhase = _allTypesOfGPSObs.Find(t => t.Contains("L1"));
            }
            else
            {
                typeOfPseudorange = _allTypesOfBDSObs.Find(t => t.Contains("C1"));
                typeOfPhase = _allTypesOfBDSObs.Find(t => t.Contains("L1"));
            }
        }

        public void GetTypeOfF2(SatelliteSystemType type, out string typeOfPseudorange, out string typeOfPhase)
        {
            if (type == SatelliteSystemType.GPS)
            {
                typeOfPseudorange = _allTypesOfGPSObs.Find(t => t.Contains("C2"));
                typeOfPhase = _allTypesOfGPSObs.Find(t => t.Contains("L2"));
            }
            else
            {
                typeOfPseudorange = _allTypesOfBDSObs.Find(t => t.Contains("C7"));
                typeOfPhase = _allTypesOfBDSObs.Find(t => t.Contains("L7"));
            }
        }

        public void GetTypeOfF3(SatelliteSystemType type, out string typeOfPseudorange, out string typeOfPhase)
        {
            if (type == SatelliteSystemType.GPS)
            {
                typeOfPseudorange = null;
                typeOfPhase = null;
            }
            else
            {
                typeOfPseudorange = _allTypesOfBDSObs.Find(t => t.Contains("C6"));
                typeOfPhase = _allTypesOfBDSObs.Find(t => t.Contains("L6"));
            }
        }

        /// <summary>
        /// 设置所有GPS和BDS卫星的PRN号
        /// </summary>
        private void SetAllPrnsOfSatellites()
        {
            List<string> comments = GetCommentsOf("PRN / # OF OBS");
            if (comments != null)
            {
                foreach (string comment in comments)
                {
                    if ((SatelliteSystemType)comment[3] == SatelliteSystemType.GPS || (SatelliteSystemType)comment[3] == SatelliteSystemType.BDS)
                    {
                        _allPrnsOfGPSAndBDS.Add(comment.Substring(3, 3));
                    }
                }
            }
            else
            {
                foreach (RinexFileDataRecord rinexFileDataRecord in _dataRecord)
                {
                    foreach (ObservationsOfSatellite observationsOfSatellite in rinexFileDataRecord.ObservationsOfSatellites)
                    {
                        if (!_allPrnsOfGPSAndBDS.Contains(observationsOfSatellite.PRNOfSatellite))
                        {
                            _allPrnsOfGPSAndBDS.Add(observationsOfSatellite.PRNOfSatellite);
                        }
                    }
                }
            }
            _allPrnsOfGPSAndBDS.TrimExcess();
        }

        /// <summary>
        /// 设置卫星系统的所有观测值类型
        /// </summary>
        private void SetAllTypesOfSatelliteSystemObs()
        {
            List<string> comments = GetCommentsOf("SYS / # / OBS TYPES");
            SatelliteSystemType systemType = SatelliteSystemType.GPS;
            foreach (string comment in comments)
            {
                if (comment[0] != ' ')
                {
                    systemType = (SatelliteSystemType)comment[0];
                }
                if (systemType != SatelliteSystemType.GPS && systemType != SatelliteSystemType.BDS)
                {
                    continue;
                }
                string[] types = comment.Substring(7).Trim().Split(' ');
                List<string> allTypes = GetAllTypesOfSatelliteSystemObservations(systemType);
                foreach (string type in types)
                {
                    allTypes.Add(type);
                }
            }
            _allTypesOfBDSObs.TrimExcess();
            _allTypesOfGPSObs.TrimExcess();
        }

        /// 设置Rinex文件数据记录
        /// 只读取GPS和BDS卫星的数据
        /// 读取所有类型观测值
        /// </summary>
        private void SetRinexDataRecord()
        {
            string firstLine = _sr.ReadLine();
            while (!_sr.EndOfStream)
            {
                string[] values = firstLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] ymdhm = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    ymdhm[i] = int.Parse(values[i + 1]);
                }
                int second = (int)double.Parse(values[6]);
                RinexFileDataRecord data = new RinexFileDataRecord(new DateTime(ymdhm[0], ymdhm[1], ymdhm[2], ymdhm[3], ymdhm[4], second));
                string line = _sr.ReadLine();
                while (!line[0].Equals('>') && !_sr.EndOfStream)
                {
                    SatelliteSystemType systemType = (SatelliteSystemType)line[0];
                    if (systemType == SatelliteSystemType.GPS || systemType == SatelliteSystemType.BDS)
                    {
                        ObservationsOfSatellite obsOfSatellite = new ObservationsOfSatellite(line.Substring(0, 3));
                        List<string> allTypesOfObs = GetAllTypesOfSatelliteSystemObservations(systemType);
                        int len = line.Length, i = 0, p = 16;
                        while (p < len && i < allTypesOfObs.Count)
                        {
                            string value = line.Substring(p - 12, 13);
                            if (!string.IsNullOrWhiteSpace(value))
                            {
                                obsOfSatellite.AddObservation(allTypesOfObs[i], double.Parse(value));
                            }
                            i++;
                            p = 16 * (i + 1);
                        }
                        data.AddObservationsOfSatellite(obsOfSatellite);
                    }
                    line = _sr.ReadLine();
                }
                data.TrimExcess();
                _dataRecord.Add(data);
                firstLine = line;
            }
            _dataRecord.TrimExcess();
        }

        /// <summary>
        /// 初始化Rinex文件
        /// </summary>
        private void SetRinexFile()
        {
            SetRinexHeader();
            SetAllTypesOfSatelliteSystemObs();
            SetRinexDataRecord();
            SetAllPrnsOfSatellites();
            _sr.Dispose();
        }

        /// <summary>
        /// 初始化Rinex文件头
        /// </summary>
        private void SetRinexHeader()
        {
            string line = _sr.ReadLine();
            string label = RinexFileComment.GetLabelFromLine(line);
            RinexFileComment rinexFileComment = new RinexFileComment(label);
            string comment = RinexFileComment.GetCommentFromLine(line);
            rinexFileComment.AddComment(comment);
            while (true)
            {
                string line1 = _sr.ReadLine();
                if (line1.Contains("END OF HEADER"))
                {
                    _comments.Add(rinexFileComment);
                    _comments.TrimExcess();
                    return;
                }
                string label1 = RinexFileComment.GetLabelFromLine(line1);
                if (label1.Equals(label))
                {
                    rinexFileComment.AddComment(RinexFileComment.GetCommentFromLine(line1));
                }
                else
                {
                    rinexFileComment.TrimExcess();
                    _comments.Add(rinexFileComment);
                    rinexFileComment = new RinexFileComment(label1);
                    rinexFileComment.AddComment(RinexFileComment.GetCommentFromLine(line1));
                    label = label1;
                }
                //}
            }
        }
    }
}