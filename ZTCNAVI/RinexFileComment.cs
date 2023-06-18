using System;
using System.Collections.Generic;
using System.Text;

namespace ZTCNAVI
{
    /// <summary>
    /// Rinex文件注释类
    /// </summary>
    internal class RinexFileComment
    {
        private readonly List<string> _comments;

        private readonly string _label;

        public RinexFileComment(string label)
        {
            _label = label;
            _comments = new List<string>();
        }

        /// <summary>
        /// 注释内容
        /// </summary>
        public string Comment
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string comment in _comments)
                {
                    stringBuilder.Append(comment + Environment.NewLine);
                }
                return stringBuilder.ToString();
            }
        }

        /// <summary>
        /// 注释行
        /// </summary>
        public List<string> Comments
        {
            get
            {
                return _comments;
            }
        }

        /// <summary>
        /// 注释标签
        /// </summary>
        public string Label
        {
            get
            {
                return _label;
            }
        }

        /// <summary>
        /// 从一行注释中截取注释内容行
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static string GetCommentFromLine(string line)
        {
            return line.Substring(0, 60);
        }

        public static DateTime GetDateTime(string line, out string timeSystemName)
        {
            string[] values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int year = int.Parse(values[0]);
            int month = int.Parse(values[1]);
            int day = int.Parse(values[2]);
            int hour = int.Parse(values[3]);
            int minute = int.Parse(values[4]);
            int second = (int)double.Parse(values[5]);
            timeSystemName = values[6];
            return new DateTime(year, month, day, hour, minute, second);
        }

        /// <summary>
        /// 从一行注释中截取注释标签
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static string GetLabelFromLine(string line)
        {
            return line.Substring(60);
        }

        /// <summary>
        /// 在注释内容末尾添加一行注释
        /// </summary>
        /// <param name="comment"></param>
        public void AddComment(string comment)
        {
            _comments.Add(comment);
        }

        /// <summary>
        /// 释放多余空间
        /// </summary>
        public void TrimExcess()
        {
            _comments.TrimExcess();
        }
    }
}