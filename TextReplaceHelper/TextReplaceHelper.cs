using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Linq.Expressions;


namespace TextReplaceHelper
{
    public partial class TextReplaceHelper : Form
    {
        public TextReplaceHelper()
        {
            InitializeComponent();
        }

        private void txtFindAll_Click(object sender, EventArgs e)
        {
            try
            {
                Regex reg = new Regex(txtReg.Text, RegexOptions.Multiline);
                DirectoryInfo di = new DirectoryInfo(txtSourceDirectory.Text);

                if (reg == null)
                {
                    throw new Exception("正则表达式错误");
                }

                if (di == null)
                {
                    throw new Exception("源文件夹路径错误");
                }
                List<string> matchString = FindInDirecotry(reg, di, "*.*", "*.*");
                FindResult(matchString);
            }
            catch (Exception ex)
            {
                OutputResult("查询时出错：", OutputMode.Set);
                OutputResult(ex.ToString(), OutputMode.Append);
            }
        }

        private void btnDefineOutput_Click(object sender, EventArgs e)
        {
            fbdDirectory.ShowDialog();
            this.txtSourceDirectory.Text = fbdDirectory.SelectedPath;
        }


        private List<string> FindInDirecotry(Regex reg, DirectoryInfo directory, string fileSearchPattern, string direcotrySearchPattern)
        {
            List<string> matchString = new List<string>();
            FileInfo[] files = directory.GetFiles(fileSearchPattern);
            DirectoryInfo[] direcotries = directory.GetDirectories(direcotrySearchPattern);

            matchString.AddRange(FindFromFiles(reg, files));

            if (direcotries != null)
            {
                foreach (DirectoryInfo di in direcotries)
                {
                    matchString.AddRange(FindInDirecotry(reg, di, fileSearchPattern, direcotrySearchPattern));
                }
            }
            return matchString;
        }

        private List<string> FindFromFiles(Regex reg, FileInfo[] files)
        {
            List<string> matchString = new List<string>();
            string fileContent = string.Empty;

            if (files != null)
            {
                foreach (FileInfo file in files)
                {
                    fileContent = GetFileContent(file);
                    MatchCollection mc = reg.Matches(fileContent);
                    
                    if (mc.Count > 0)
                    {
                        foreach (Match m in mc)
                        {
                            matchString.Add(string.Format("Find from {0}: {1}", file.FullName, m.ToString()));
                        }
                    }
                }
            }
            return matchString;
        }

        private void FindResult(List<string> matchString)
        {
            ClearOutput();
            OutputResult("查找结果：");
            OutputResult(matchString);
            OutputResult(string.Format("匹配结果：{0}", matchString.Count));
        }

        private string GetFileContent(FileInfo file)
        {
            FileStream fs = file.OpenRead();
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int)fs.Length);
            string fileContent = System.Text.Encoding.UTF8.GetString(bytes);
            fs.Close();
            return fileContent;
        }

        private void WriteFile
        

        enum OutputMode
        {
            /// <summary>
            /// 覆盖
            /// </summary>
            Set,
            /// <summary>
            /// 添加
            /// </summary>
            Append
        }

        private void ClearOutput()
        {
            txtOutput.Clear();
        }

        private void OutputResult(List<string> outputs, OutputMode mode = OutputMode.Append)
        {
            StringBuilder sbOutput = new StringBuilder();
            foreach (string output in outputs)
            {
                sbOutput.AppendLine(output);
            }
            OutputResult(sbOutput.ToString(), mode);
        }

        private void OutputResult(string output, OutputMode mode = OutputMode.Append)
        {
            switch (mode)
            {
                case OutputMode.Set:
                    txtOutput.Text = output;
                    break;
                case OutputMode.Append:
                    StringBuilder sbOutput = new StringBuilder(txtOutput.Text);
                    sbOutput.AppendLine(output);
                    txtOutput.Text = sbOutput.ToString();
                    break;
            }
        }

        private void txtReplaceAll_Click(object sender, EventArgs e)
        {
            // TODO 还未实现
        }
    }
}
