using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OneKeyBreventCaller
{
    public partial class BreventCallerMain : Form
    {
        private int count;
        private Process p = new Process();

        private void ProcessInit()
        {
            p.StartInfo.FileName = "./ADB_Bin/adb.exe";//设定程序名
            p.StartInfo.UseShellExecute = false; //关闭shell的使用
            p.StartInfo.RedirectStandardInput = true; //重定向标准输入
            p.StartInfo.RedirectStandardOutput = true; //重定向标准输出
            p.StartInfo.RedirectStandardError = true; //重定向错误输出
            p.StartInfo.CreateNoWindow = true;//设置不显示窗口
        }

        private void DeviceScanner()
        {
            ProcessInit();
            p.StartInfo.Arguments = " kill-server";
            p.Start();
            p.Close();
            p.StartInfo.Arguments = " shell getprop ro.product.model";
            p.Start();
            DeviceInfoStr.Text = p.StandardOutput.ReadToEnd();
            p.Close();
            if (DeviceInfoStr.Text == "")
            {
                if (count <= 5)
                {
                    DialogResult result = MessageBox.Show(@"请确保手机已连接并开启USB调试！", @"提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        DeviceScanner();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        DeviceInfoStr.Text = @"（暂无）";
                    }
                }
            }
        }

        public BreventCallerMain()
        {
            InitializeComponent();
        }
        private void BreventCallerMain_Load(object sender, EventArgs e)
        {
            DeviceScanner();
        }
        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            DeviceScanner();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            ProcessInit();
            p.StartInfo.Arguments = " -d shell sh /data/data/me.piebridge.brevent/brevent.sh";
            p.Start();
            string msg = p.StandardOutput.ReadToEnd();
            p.Close();
            if(msg != "")
            {
                DialogResult res = MessageBox.Show("黑阈启动成功！\n"+msg, @"恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show(@"黑阈启动失败，请确保手机已连接并开启USB调试！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
