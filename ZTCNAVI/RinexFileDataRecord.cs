using System;
using System.Collections.Generic;
using System.Linq;

namespace ZTCNAVI
{
    /// <summary>
    /// Rinex数据类
    /// </summary>
    internal class RinexFileDataRecord
    {
        private readonly DateTime _dateTime;

        private readonly List<ObservationsOfSatellite> _obsData;

        public RinexFileDataRecord(DateTime dateTime)
        {
            _dateTime = dateTime;
            _obsData = new List<ObservationsOfSatellite>();
        }

        /// <summary>
        /// 历元
        /// </summary>
        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }
        }

        /// <summary>
        /// 所有卫星的所有观测数据
        /// </summary>
        public List<ObservationsOfSatellite> ObservationsOfSatellites
        {
            get
            {
                return _obsData;
            }
        }

        /// <summary>
        /// 获取指定卫星的观测数据
        /// 若本历元无此卫星，则返回null
        /// </summary>
        /// <param name="prn"></param>
        /// <returns></returns>
        public ObservationsOfSatellite this[string prn]
        {
            get
            {
                return GetObservationsOfSatellite(prn);
            }
        }

        /// <summary>
        /// 获取指定卫星的指定类型的观测数据
        /// 若本历元无此卫星或该卫星无指定类型的观测数据，返回NaN
        /// </summary>
        /// <param name="prn"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public double this[string prn, string type]
        {
            get
            {
                return GetObservationOfSatellite(prn, type);
            }
        }

        /// <summary>
        /// 在数据列表末尾添加一个卫星的观测数据
        /// </summary>
        /// <param name="observations"></param>
        public void AddObservationsOfSatellite(ObservationsOfSatellite observations)
        {
            _obsData.Add(observations);
        }

        /// <summary>
        /// 获取指定卫星的指定类型的观测数据
        /// 若本历元无此卫星或该卫星无指定类型的观测数据，返回NaN
        /// </summary>
        /// <param name="prn"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public double GetObservationOfSatellite(string prn, string type)
        {
            ObservationsOfSatellite obs = GetObservationsOfSatellite(prn);
            if (obs != null) return obs[type];
            return double.NaN;
        }

        /// <summary>
        /// 获取指定卫星的观测数据
        /// 若本历元无此卫星，则返回null
        /// </summary>
        /// <param name="prn"></param>
        /// <returns></returns>
        public ObservationsOfSatellite GetObservationsOfSatellite(string prn)
        {
            return _obsData.FirstOrDefault(t => t.PRNOfSatellite.Equals(prn));
        }

        /// <summary>
        /// 去除空余内存占用
        /// </summary>
        public void TrimExcess()
        {
            _obsData.TrimExcess();
        }
    }
}