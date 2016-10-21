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
            loadButton();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private void runButton(object sender, EventArgs e)
        {
            Button b = sender as Button;

        }
        private void newButton_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }
        private void loadButton()
        {
            int x = this.Width / 2 + 50;
            int y = this.Height / 6;
            int s = 80;
            string[] lines = File.ReadAllLines(@"D:\\gamelist.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                GameButton b = new GameButton(lines[i]);
                b.Width = s;
                b.Height = s;
                b.Left = x;
                b.Top = y;
                Controls.Add(b);
                if ((i + 1) % 3 == 0)
                {
                    x = this.Width / 2 + 50;
                    y += s;
                }
                else
                {
                    x += s;
                }
            }
            Button addGame = new Button();
            addGame.Text = "Add new game";
            addGame.Left = x;
            addGame.Top = y;
            addGame.Width = s;
            addGame.Height = s;
            addGame.Click += new EventHandler(addGame_click);
            Controls.Add(addGame);
        }
        private void addGame_click(object sender, EventArgs e)
        {

        }
    }
}
