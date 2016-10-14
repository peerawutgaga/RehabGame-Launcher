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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void banner_Click(object sender, EventArgs e)
        {
            //This function is not used.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sexSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
