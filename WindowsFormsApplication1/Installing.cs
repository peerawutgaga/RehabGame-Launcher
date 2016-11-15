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
        private int fileCount,r;
        private BackgroundWorker bg = new BackgroundWorker();
        public Installing()
        {
            InitializeComponent();
        }
        public void setValue(string s, string l, string n)
        {
            gameSource = s;
            gameLocation = l;
            gameName = n;
        }
        public void startInstall()
        {
            this.Show();
            r = 0;
            fileCount = Directory.GetFiles(gameSource, "*.*", SearchOption.AllDirectories).Length;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = fileCount;
            copyfolder(gameSource, gameLocation + "\\" + gameName);
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
                r++;
                progressBar1.Value = r;
            }
            //copy sub folder
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                copyfolder(subdir.FullName, temppath);

            }
        }
       
    }
}
