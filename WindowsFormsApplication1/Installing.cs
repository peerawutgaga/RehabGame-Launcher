using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Installing : Form
    {
        private string gameSource, gameLocation, gameName;
        private int mode;
        public Installing()
        {
            InitializeComponent();
        }
        public void setValue(string s, string l, string n, int m)
        {
            gameSource = s;
            gameLocation = l;
            gameName = n;
            mode = m;
        }
        public void startInstall()
        {
            BackgroundWorker bg = new BackgroundWorker();
            
            switch (mode)
            {
                case 2: bg.DoWork += new DoWorkEventHandler(installAtCustomPath);
                    break;
                case 1:
                    bg.DoWork += new DoWorkEventHandler(installAtDefaultPath);
                    break;
            }
            bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(finishInstallaion);
            bg.RunWorkerAsync();
            this.Show();
        }
        private void installAtCustomPath(object sender, DoWorkEventArgs e)
        {

            copyfolder(gameSource, gameLocation + "\\" + gameName);
        }
        private void installAtDefaultPath(object sender, DoWorkEventArgs e)
        {

        }
        private void finishInstallaion(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            
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
        private int fileCount(string sourceDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            DirectoryInfo[] dirs = dir.GetDirectories();
            int fCount = 0;
            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                fCount++;
            }
            //copy sub folder
            foreach (DirectoryInfo subdir in dirs)
            {

                fCount += fileCount(subdir.FullName);
            }
            return fCount;
        }
    }
}
