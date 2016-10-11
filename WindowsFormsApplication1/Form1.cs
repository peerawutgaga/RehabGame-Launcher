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
            //path = Path.Combine(path, "\\app\Game 1\RehabGame1Package");
            //Process.Start("F:\\Game 1\\WindowsNoEditor\\RehabGame1Package.exe");
            label1.Text = path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start("");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
