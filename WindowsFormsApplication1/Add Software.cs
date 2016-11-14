using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Add_Software : Form
    {
        private string gameLocation;
        private string gameName;
        private string gameSource;
        private string originalName;
        private Installing installingForm = new Installing();
        public Add_Software()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            swLocation.Hide();
            swNameLabel.Hide();
            swNameBox.Hide();
            currentLocation.Hide();
            currentLocationShow.Hide();
            defaultLocation.Hide();
            defaultLocation.Checked = true;
            customLocation.Hide();
            customLocationButton.Hide();
            customLocationLabel.Hide();
            installButton.Enabled = false;
            installingForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            installingForm.MaximizeBox = false;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                gameName = Path.GetFileNameWithoutExtension(op.FileName);
                gameLocation = Path.GetDirectoryName(op.FileName);
                gameSource = gameLocation;
                swNameBox.Text = gameName;
                originalName = swNameBox.Text;
                currentLocationShow.Text = gameLocation;
                currentLocationShow.MaximumSize = new Size(380, 0);
                currentLocationShow.AutoSize = true;
                swLocation.Show();
                swNameLabel.Show();
                swNameBox.Show();
                currentLocation.Show();
                currentLocationShow.Show();
                defaultLocation.Show();
                customLocation.Show();
                installButton.Enabled = true;
            }         
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            if (gameName == "")
            {
                MessageBox.Show("กรุณาใส่ชื่อ Software", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (customLocation.Checked)
            {
                installingForm.setValue(gameSource, gameLocation, gameName, 2);
                installingForm.startInstall();
            }
            else if (defaultLocation.Checked)
            {
                installingForm.setValue(gameSource, gameLocation, gameName, 1);
            }
           
            if (originalName != gameName)
            {
                string s = gameLocation + "\\" + gameName + "\\" + originalName + ".exe";
                string d = gameLocation + "\\" + gameName + "\\" + gameName + ".exe";
                if (File.Exists(s))
                {
                    File.Move(s, d);
                    File.Delete(s);
                }
                
            }
            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\Users\\Peerawut\\Documents\\gamelist.txt", true))
            {
                file.WriteLine(gameName);
                file.WriteLine(gameLocation+"\\"+gameName+"\\"+gameName+".exe");
            }
            Close();
        }
        
        private void custonLocation_checked(object sender, EventArgs e)
        {
            customLocationButton.Show();
            installButton.Enabled = false;
        }

        private void customLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                gameLocation = fbd.SelectedPath;
                customLocationLabel.Text = gameLocation;
                customLocationLabel.Show();
                installButton.Enabled = true;
            }
        }
        

        private void swNameBox_TextChanged(object sender, EventArgs e)
        {
            
                gameName = swNameBox.Text;
            
            
        }
    }
}
