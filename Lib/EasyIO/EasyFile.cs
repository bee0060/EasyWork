using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EasyIO
{
    public class EasyFile 
    {
        private System.IO.FileInfo file;

        public EasyFile(string fileName) 
        {
            file = new FileInfo(fileName);        
        }

        /// <summary>
        /// 获取文件内容
        /// Steven Weng 2014-09-16
        /// </summary>
        /// <returns></returns>
        public string GetFileContent()
        {
            FileStream fs = file.OpenRead();
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int)fs.Length);
            string fileContent = System.Text.Encoding.UTF8.GetString(bytes);
            fs.Close();
            return fileContent;
        }



    }
}
