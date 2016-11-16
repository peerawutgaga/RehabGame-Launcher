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
        private List<GameButton> bs = new List<GameButton>();
        private Button addGame = new Button();
        private DataGrid dg = new DataGrid();
        private DataTable tb = new DataTable();
        private bool isCancel = true;
        public MainWindow()
        {
            InitializeComponent();
            addGame.Text = "Add new game";
            addGame.Click += new EventHandler(addGame_click);
            loadButton();
            initialDataGrid();
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
            r.FormClosing += new FormClosingEventHandler(this.registerForm_closeing);
            r.Show();
        }
        private void registerForm_closeing(object sender, FormClosingEventArgs e)
        {
            tb.Clear();
            updateDataGrid();
        }
        private void addSoftwareForm_closeing(object sender, FormClosingEventArgs e)
        {
            bs.Clear();
            Controls.Remove(addGame);
            loadButton();
        }
        private void loadButton()
        {
            int x = this.Width / 2 + 50;
            int y = this.Height / 6;
            int s = 80;
            int idx = 0;
            if (!File.Exists(Directory.GetCurrentDirectory()+"\\gamelist.txt"))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Directory.GetCurrentDirectory() + "\\gamelist.txt", true)) ;         
            }
            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\gamelist.txt");
            for (int i = 0; i < lines.Length; i += 2)
            {
                GameButton b = new GameButton(lines[i]);
                b.setPath(lines[i + 1]);
                b.Click += new EventHandler(runButton);
                b.Width = s;
                b.Height = s;
                b.Left = x;
                b.Top = y;
                bs.Add(b);
                if ((idx + 1) % 3 == 0)
                {
                    x = this.Width / 2 + 50;
                    y += s+10;
                }
                else
                {
                    x += s+10;
                }
                idx++;
            }
            addGame.Left = x;
            addGame.Top = y;
            addGame.Width = s;
            addGame.Height = s;
            addbuttontoform();
            
        }
        private void addbuttontoform()
        {
            foreach(GameButton b in bs)
            {
                Controls.Add(b);
            }
            Controls.Add(addGame);
        }
        private void addGame_click(object sender, EventArgs e)
        {
            Add_Software a = new Add_Software();
            a.FormClosing += new FormClosingEventHandler(this.addSoftwareForm_closeing);
            a.Show();
        }
        private void initialDataGrid()
        {
            if (!File.Exists(Directory.GetCurrentDirectory()+"\\userdata.csv"))
            {
                using (System.IO.StreamWriter file = new StreamWriter(Directory.GetCurrentDirectory() +"\\userdata.csv", true, Encoding.UTF8))
                {
                    file.WriteLine("รหัส,คำนำหน้าชื่อ,ชื่อ,นามสกุล,วันเกิด,เดือนเกิด,ปีเกิด (พ.ศ.)");
                }
            }
           
            string[] rawText = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\userdata.csv");
            string[] col = null;
            dg.Size = new Size(360, 380);
            dg.Location = new Point(20, 30);
            dg.ReadOnly = true;
            
            col = rawText[0].Split(',');
            for(int i = 0; i < col.Length; i++)
            {
                tb.Columns.Add(col[i]);
            }
            for (int i = 1;i<rawText.Length;i++)
            {
                col = rawText[i].Split(',');
                    tb.Rows.Add(col);
                
            }
            dg.DataSource = tb;
            this.Controls.Add(dg);
        }
        private void updateDataGrid()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\userdata.csv"))
            {
                using (System.IO.StreamWriter file = new StreamWriter(Directory.GetCurrentDirectory() + "\\userdata.csv", true, Encoding.UTF8))
                {
                    file.WriteLine("รหัส,คำนำหน้าชื่อ,ชื่อ,นามสกุล,วันเกิด,เดือนเกิด,ปีเกิด (พ.ศ.)");
                }
            }
            string[] rawText = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\userdata.csv");
            string[] col = null;
            col = rawText[0].Split(',');
            for (int i = 1; i < rawText.Length; i++)
            {
                col = rawText[i].Split(',');
                tb.Rows.Add(col);

            }
        }

    }
}
