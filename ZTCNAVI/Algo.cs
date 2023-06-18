using static System.Math;
using static ZTCNAVI.Data;

namespace ZTCNAVI
{
    internal static class Algo
    {
        public static void GetMP(out double MP1, out double MP2, SatelliteSystemType type, params double[] PseudoRangeAndPhaseAtL1L2OrB1B2)
        {
            GetF1F2(type, out double f1, out double f2);
            double rho1 = PseudoRangeAndPhaseAtL1L2OrB1B2[0];
            double rho2 = PseudoRangeAndPhaseAtL1L2OrB1B2[1];
            double phi1 = PseudoRangeAndPhaseAtL1L2OrB1B2[2] * c / f1;
            double phi2 = PseudoRangeAndPhaseAtL1L2OrB1B2[3] * c / f2;
            double f1_2 = Pow(f1, 2);
            double f2_2 = Pow(f2, 2);
            double add = f1_2 + f2_2;
            double sub = f1_2 - f2_2;
            MP1 = rho1 - add / sub * phi1 + 2 * f2_2 / sub * phi2;
            MP2 = rho2 - 2 * f1_2 / sub * phi1 + add / sub * phi2;
        }

        public static void GetMWAndGF(out double MW, out double GF, SatelliteSystemType type, params double[] PseudoRangeAndPhaseAtL1L2OrB1B2)
        {
            GetF1F2(type, out double f1, out double f2);
            double rho1 = PseudoRangeAndPhaseAtL1L2OrB1B2[0];
            double rho2 = PseudoRangeAndPhaseAtL1L2OrB1B2[1];
            double phi1 = PseudoRangeAndPhaseAtL1L2OrB1B2[2];
            double phi2 = PseudoRangeAndPhaseAtL1L2OrB1B2[3];
            MW = (c * phi1 - c * phi2) / (f1 - f2) - (f1 * rho1 + f2 * rho2) / (f1 + f2);
            GF = phi1 * c / f1 - phi2 * c / f2;
        }
    }
}