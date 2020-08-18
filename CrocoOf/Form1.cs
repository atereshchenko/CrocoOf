using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;

namespace Croco
{
    /// <summary>
    /// https://professorweb.ru/my/csharp/base_net/level4/4_5.php
    /// </summary>
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStatus();
        }        

        private void btnOnOf_Click(object sender, EventArgs e)
        {            
            if (ifRunning())
            {               
                RunPsExec("stop");
                GetStatus();
                btnOnOf.Text = "Stop";
                toolStripMenuOnOf.Text = "Stop";
            }
            else
            {                
                RunPsExec("start");
                GetStatus();
                btnOnOf.Text = "Start";
                toolStripMenuOnOf.Text = "Start";
            }            
        }

        private void toolStripMenuOnOf_Click(object sender, EventArgs e)
        {
            if (ifRunning())
            {
                RunPsExec("stop");
                GetStatus();
                btnOnOf.Text = "Stop";
                toolStripMenuOnOf.Text = "Stop";
            }
            else
            {
                RunPsExec("start");
                GetStatus();
                btnOnOf.Text = "Start";
                toolStripMenuOnOf.Text = "Start";
            }
        }

        private static bool ifRunning()
        {
            ServiceController sc = new ServiceController("CrocoTime Agent");
            bool result = (sc.Status == ServiceControllerStatus.Running) ? true : false;
            return result;
        }

        private void GetStatus()
        {
            ServiceController sc = new ServiceController("CrocoTime Agent");
            var tmp = sc.Status;
            if (sc.Status == ServiceControllerStatus.Running)
            {
                btnOnOf.Text = "Stop";
                toolStripMenuOnOf.Text = "Stop";
            }
            else
            {
                btnOnOf.Text = "Start";
                toolStripMenuOnOf.Text = "Start";
            }
            label1.Text = tmp.ToString();            
        }

        private void RunPsExec(string command)
        {            
            try
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;                
                string psexec = Directory.GetCurrentDirectory() + "\\tools\\PsExec.exe";
                p.StartInfo.FileName = psexec;
                p.StartInfo.Arguments = $"-i -s net {command} \"CrocoTime Agent\"";
                p.Start();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetStatus();
        }
    }
}
