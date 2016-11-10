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
        private Installing installingForm;
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
            BackgroundWorker bg = new BackgroundWorker();
            if (customLocation.Checked)
            {
                bg.DoWork += new DoWorkEventHandler(installAtCustomPath);
                bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(finishInstallaion);
                bg.RunWorkerAsync();
               installingForm = new Installing();
                installingForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                installingForm.MaximizeBox = false;
                installingForm.ShowDialog();
                
            }
            else if (defaultLocation.Checked)
            {
                
            }
            string s = gameLocation + "\\"+gameName+"\\" + originalName + ".exe";
            string d = gameLocation + "\\"+gameName+"\\" + swNameBox.Text + ".exe";
            File.Move(s,d );
            File.Delete(s);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\Users\\Peerawut\\Documents\\gamelist.txt", true))
            {
                file.WriteLine(gameName);
                file.WriteLine(gameLocation+"\\"+gameName+"\\"+gameName+".exe");
            }
            Close();
        }
        private void installAtCustomPath(object sender,DoWorkEventArgs e)
        {
            copyfolder(gameSource, gameLocation + "\\" + gameName);
        }
        private void installAtDefaultPath(object sender, DoWorkEventArgs e)
        {
            
        }
        private void finishInstallaion(object sender,RunWorkerCompletedEventArgs e)
        {
            installingForm.Close();
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
        private void copyfolder(string sourceDirName, string destDirName)
        {
           DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }
            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }
          
            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }
             //copy sub folder
            foreach (DirectoryInfo subdir in dirs)
            {
                 string temppath = Path.Combine(destDirName, subdir.Name);
                 copyfolder(subdir.FullName, temppath);
            }  
        }

        private void swNameBox_TextChanged(object sender, EventArgs e)
        {
            
                gameName = swNameBox.Text;
            
            
        }
    }
}
