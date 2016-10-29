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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            loadButton();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void runButton(object sender, EventArgs e)
        {
            GameButton b = sender as GameButton;
            Process p = Process.Start(b.GetPath());
            this.WindowState = FormWindowState.Minimized;
            p.WaitForExit();
            this.WindowState = FormWindowState.Normal;

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
                b.Click += new EventHandler(runButton);
                b.Width = s;
                b.Height = s;
                b.Left = x;
                b.Top = y;
                Controls.Add(b);
                if ((i + 1) % 3 == 0)
                {
                    x = this.Width / 2 + 50;
                    y += s+10;
                }
                else
                {
                    x += s+10;
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
            Add_Software a = new Add_Software();
            a.Show();
        }
    }
}
