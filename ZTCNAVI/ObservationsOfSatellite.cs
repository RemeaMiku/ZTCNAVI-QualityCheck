using System.Collections.Generic;
using System.Linq;

namespace ZTCNAVI
{
    /// <summary>
    /// 卫星观测值类
    /// </summary>
    internal class ObservationsOfSatellite
    {
        private readonly string _prn;

        private readonly Dictionary<string, double> _valueOfObs;

        public ObservationsOfSatellite(string prn)
        {
            _prn = prn;
            _valueOfObs = new Dictionary<string, double>();
        }

        /// <summary>
        /// 卫星的PRN号
        /// </summary>
        public string PRNOfSatellite
        {
            get
            {
                return _prn;
            }
        }

        /// <summary>
        /// 卫星所属的系统类型
        /// </summary>
        public SatelliteSystemType TypeOfSatellite
        {
            get
            {
                return (SatelliteSystemType)_prn[0];
            }
        }

        ///// <summary>
        ///// 卫星的所有观测值
        ///// </summary>
        //public List<double> Observations
        //{
        //    get
        //    {
        //        return _valueOfObs.Values.ToList();
        //    }
        //}
        /// <summary>
        /// 卫星的所有观测值的类型
        /// </summary>
        public List<string> TypesOfObservations
        {
            get
            {
                return _valueOfObs.Keys.ToList();
            }
        }

        /// <summary>
        /// 获取卫星观测值中的一个观测值类型的值
        /// 若该卫星观测值中没有此项，则返回NaN
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public double this[string type]
        {
            get
            {
                return GetValueOfObservation(type);
            }
        }

        /// <summary>
        /// 在卫星观测值末尾添加一个类型的观测值
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public void AddObservation(string type, double value) => _valueOfObs.Add(type, value);

        /// <summary>
        /// 获取双频伪距和相位观测值
        /// 0:C1
        /// 1:C2
        /// 2:L1
        /// 3:L2
        /// </summary>
        /// <returns></returns>
        public double[] GetPseudoRangeAndPhaseAtF1F2()
        {
            string typeOfC1, typeOfC2, typeOfL1, typeOfL2;
            if (TypeOfSatellite == SatelliteSystemType.GPS)
            {
                typeOfC1 = TypesOfObservations.Find(t => t.Contains("C1"));
                typeOfC2 = TypesOfObservations.Find(t => t.Contains("C2"));
                typeOfL1 = TypesOfObservations.Find(t => t.Contains("L1"));
                typeOfL2 = TypesOfObservations.Find(t => t.Contains("L2"));
            }
            else
            {
                typeOfC1 = TypesOfObservations.Find(t => t.Contains("C1"));
                typeOfL1 = TypesOfObservations.Find(t => t.Contains("L1"));
                if (Data.useB1B2)
                {
                    typeOfC2 = TypesOfObservations.Find(t => t.Contains("C7"));
                    typeOfL2 = TypesOfObservations.Find(t => t.Contains("L7"));
                }
                else
                {
                    typeOfC2 = TypesOfObservations.Find(t => t.Contains("C6"));
                    typeOfL2 = TypesOfObservations.Find(t => t.Contains("L6"));
                }
            }
            return new double[4] { this[typeOfC1], this[typeOfC2], this[typeOfL1], this[typeOfL2] };
        }

        /// <summary>
        /// 获取卫星观测值中的一个观测值类型的值
        /// 若该卫星观测值中没有此项或输入的观测值类型为null，则返回NaN
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public double GetValueOfObservation(string type)
        {
            if (type != null)
            {
                if (TypesOfObservations.Contains(type))
                {
                    return _valueOfObs[type];
                }
            }
            return double.NaN;
        }
    }
}