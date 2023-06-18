using System.Collections.Generic;

namespace ZTCNAVI
{
    internal enum SatelliteSystemType
    {
        GPS = 'G',
        GLONASS = 'R',
        Galileo = 'E',
        QZSS = 'J',
        BDS = 'C',
        IRNSS = 'I',
        SBASpayload = 'S',
        Mixed = 'M'
    }

    internal static class Data
    {
        public const double c = 299792458;

        public static readonly Dictionary<string, double> FrequencyOf = new Dictionary<string, double>()
        {
            { "L1", 1575.42e6 },
            { "L2", 1227.60e6 },
            { "B1", 1561.098e6 },
            { "B2", 1207.140e6 },
            { "B3", 1268.52e6 }
        };

        public static double GFThreshold = 0.05;
        public static int MWThreshold = 2;
        public static List<RinexFileQualityCheck> RinexFileQualityChecks = new List<RinexFileQualityCheck>();
        public static List<RinexFile> RinexFiles = new List<RinexFile>();
        public static bool useB1B2 = true;

        public static void Delete(RinexFile rF)
        {
            RinexFiles.Remove(rF);
        }

        public static void Delete(RinexFileQualityCheck qc)
        {
            RinexFileQualityChecks.Remove(qc);
        }

        public static void GetF1F2(SatelliteSystemType type, out double f1, out double f2)
        {
            if (type == SatelliteSystemType.GPS)
            {
                f1 = FrequencyOf["L1"];
                f2 = FrequencyOf["L2"];
            }
            else
            {
                f1 = FrequencyOf["B1"];
                if (useB1B2)
                {
                    f2 = FrequencyOf["B2"];
                }
                else
                {
                    f2 = FrequencyOf["B3"];
                }
            }
        }

        public static int IndexOf(RinexFile rF)
        {
            return RinexFiles.IndexOf(rF);
        }

        public static int IndexOf(RinexFileQualityCheck qc)
        {
            return RinexFileQualityChecks.IndexOf(qc);
        }
    }
}