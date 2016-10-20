using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            path += "\\app\\Game 1\\RehabGame1Package.exe";
            // Process gameProcess = Process.Start(path);
            //Process gameProcess = Process.Start("C:\\Users\\peerawut\\Documents\\Game 1\\WindowsNoEditor\\RehabGame1Package.exe");
            this.WindowState = FormWindowState.Minimized;
            //gameProcess.WaitForExit();
            this.WindowState = FormWindowState.Normal;     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            path += "\\app\\Game 2\\RehabGame2Package.exe";
            // Process gameProcess = Process.Start(path);
            // Process gameProcess = Process.Start("C:\\Users\\peerawut\\Documents\\Game 2\\WindowsNoEditor\\RehabGame2Package.exe");
            this.WindowState = FormWindowState.Minimized;
            //gameProcess.WaitForExit();
            this.WindowState = FormWindowState.Normal;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
