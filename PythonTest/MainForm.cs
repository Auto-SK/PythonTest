using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythonTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static void RunPythonScript(string sArguments)
        {
            Process p = new Process();
            p.StartInfo.FileName = @"PythonEnvs\python27\python.exe";  // Python 的安装路径
            p.StartInfo.Arguments = sArguments;  // Python 命令的参数
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.CreateNoWindow = false;
            p.Start();  // 启动进程
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //string sArguments = @"PythonScripts\pyMAPOD\pyMAPOD.pyc";  // 调用 Python 二进制文件
            string sArguments = @"PythonScripts\pyMAPOD\pyMAPOD.py";  // 调用 Python 脚本
            RunPythonScript(sArguments);
        }
    }
}
