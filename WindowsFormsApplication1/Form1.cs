using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            var path = Directory.GetCurrentDirectory();
            path += "\\app\\Game 1\\RehabGame1Package.exe";
            //Process.Start(path);
            this.WindowState = FormWindowState.Minimized;
            // while (Process.GetProcessesByName("RehabGame1Package").Length > 0) ;
            this.WindowState = FormWindowState.Normal;     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            path += "\\app\\Game 2\\RehabGame2Package.exe";
            //Process.Start(path);
             Process.Start("D:\\Program\\ImageToPDForXPS.exe");
            this.WindowState = FormWindowState.Minimized;
            while (Process.GetProcessesByName("ImageToPDForXPS").Length > 0) ;
           // while (Process.GetProcessesByName("RehabGame2Package").Length > 0) ;
            this.WindowState = FormWindowState.Normal;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }
    }
}
