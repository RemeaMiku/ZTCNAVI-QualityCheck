namespace ZTCNAVI
{
    internal class SlipDetectionOfSatellite
    {
        public SlipDetectionOfSatellite(string pRn)
        {
            PRN = pRn;
            ValidDualFrequencyObservationsCount = 0;
            SlipCount = 0;
        }

        public float NoneSlipRatio
        {
            get
            {
                return 1 - ((float)SlipCount / ValidDualFrequencyObservationsCount);
            }
        }

        public string PRN { get; set; }
        public int SlipCount { get; set; }
        public int ValidDualFrequencyObservationsCount { get; set; }
    }
}