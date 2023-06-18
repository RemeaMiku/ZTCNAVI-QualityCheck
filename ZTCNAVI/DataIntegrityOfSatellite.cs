namespace ZTCNAVI
{
    internal class DataIntegrityOfSatellite
    {
        public DataIntegrityOfSatellite(string pRN)
        {
            PRN = pRN;
            ActualEpochCountAtB3 = 0;
            ActualEpochCountAtL1OrB1 = 0;
            ActualEpochCountAtL2OrB2 = 0;
            ActualEpochAtAll = 0;
            TheoreticalEpochCount = 0;
        }

        public int ActualEpochAtAll { get; set; }
        public int ActualEpochCountAtB3 { get; set; }
        public int ActualEpochCountAtL1OrB1 { get; set; }
        public int ActualEpochCountAtL2OrB2 { get; set; }
        public string PRN { get; }

        public SatelliteSystemType SatelliteSystemType
        {
            get
            {
                return (SatelliteSystemType)PRN[0];
            }
        }

        public int TheoreticalEpochCount { get; set; }
    }
}