using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Add_Software : Form
    {
        private string gameLocation;
        private string gameName;
        public Add_Software()
        {
            
            InitializeComponent();
            swLocation.Hide();
            swNameLabel.Hide();
            swNameShow.Hide();
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
               gameLocation = op.FileName;
               gameName = System.IO.Path.GetFileNameWithoutExtension(gameLocation);
                swNameShow.Text = gameName;
                currentLocationShow.Text = gameLocation;
                currentLocationShow.MaximumSize = new Size(380, 0);
                currentLocationShow.AutoSize = true;
                swLocation.Show();
                swNameLabel.Show();
                swNameShow.Show();
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
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\\gamelist.txt", true))
            {
                file.WriteLine(gameName);
                file.WriteLine(gameLocation);
            }
            Close();
        }
        private void custonLocation_checked(object sender, EventArgs e)
        {
            customLocationButton.Show();
            installButton.Enabled = false;
        }
    }
}
