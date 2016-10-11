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
            //Process.Start(path);
            label1.Text = path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory();
            //path = Path.Combine(path, "\\app\Game 2\RehabGame1Package");
            //Process.Start(path);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
