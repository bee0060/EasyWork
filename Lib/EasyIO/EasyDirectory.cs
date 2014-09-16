using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EasyIO
{
    public class EasyDirectory
    {
        private System.IO.DirectoryInfo directory;

        /// <summary>
        /// 用文件夹路径对象构造
        /// Steven Weng 2014-09-16
        /// </summary>
        public EasyDirectory(string path)
        {
            this.directory = new DirectoryInfo(path);
        }

        /// <summary>
        /// 用DirectoryInfo对象构造
        /// Steven Weng 2014-09-16
        /// </summary>
        /// <param name="directory"></param>
        public EasyDirectory(DirectoryInfo directory)
        {
            this.directory = directory;
        }

        /// <summary>
        /// 获取文件夹内的文件集合
        /// Steven Weng 2014-09-16
        /// </summary>
        /// <param name="recursive">是否递归获取子文件夹中的文件</param>
        /// <returns></returns>
        public List<FileInfo> GetFiles(bool recursive)
        {
            List<FileInfo> files = new List<FileInfo>();
            files.AddRange(directory.GetFiles());

            if (recursive)
            {
                EasyDirectory currentSubDirectory = null;
                DirectoryInfo[] direcotries = directory.GetDirectories();
                if (direcotries != null)
                {
                    foreach (DirectoryInfo di in direcotries)
                    {
                        currentSubDirectory = new EasyDirectory(di);
                        files.AddRange(currentSubDirectory.GetFiles(recursive));
                    }
                }
            }
            return files;
        }
    }
}
