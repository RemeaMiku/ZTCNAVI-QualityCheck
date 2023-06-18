using System.IO;
using System.Windows.Forms;

namespace RMM
{
    /// <summary>
    /// 文件名：静态文件读写辅助工具类
    /// </summary>
    public static class RMM_FileHelper
    {
        /// <summary>
        /// 获取拟读取的文件流
        /// 若取消，则返回null
        /// </summary>
        /// <param name="title">对话框标题</param>
        /// <param name="type">文件类型</param>
        /// <param name="fileName">文件绝对路径</param>
        /// <returns></returns>
        public static StreamReader[] ReadFile(string title, string type, out string[] filePaths)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = title,
                Filter = type,
                RestoreDirectory = true,
                Multiselect = true,
                AddExtension = true,
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int num = openFileDialog.FileNames.Length;
                StreamReader[] streamReaders = new StreamReader[num];
                for (int i = 0; i < num; i++)
                {
                    streamReaders[i] = new StreamReader(new FileStream(openFileDialog.FileNames[i], FileMode.Open, FileAccess.Read));
                }
                filePaths = openFileDialog.FileNames;
                return streamReaders;
            }
            filePaths = null;
            return null;
        }

        ///// <summary>
        ///// 获取拟创建的文件流
        ///// 若取消，则返回null
        ///// </summary>
        ///// <param name="title">对话框标题</param>
        ///// <param name="fileName">文件绝对路径</param>
        ///// <param name="type">文件类型</param>
        ///// <returns></returns>
        //static public StreamWriter WriteFile(string title, ref string fileName, string type)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog
        //    {
        //        Title = title,
        //        FileName = fileName,
        //        Filter = type,
        //        RestoreDirectory = true
        //    };
        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        fileName = saveFileDialog.FileName;
        //        return new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write));
        //    }
        //    return null;
        //}
    }
}