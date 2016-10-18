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
            if (sexSelector.SelectedIndex < 0)
            {
                MessageBox.Show("Please select sex", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(nameBox.Text == ""||surnameBox.Text == "")
            {
                MessageBox.Show("Name or Surname must not be blank", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isValidBirthDay(birthdayBox.Text, birthmonthSelector.SelectedIndex, birthyearBox.Text))
            {
                MessageBox.Show("Birthday is not appropriate", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string writeData = sexSelector.Text + " " + nameBox.Text + " " + surnameBox.Text + " "
                + birthdayBox.Text + " " +( birthmonthSelector.SelectedIndex+1) + " " + birthyearBox.Text;
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\\Users\\peerawut\\Documents\\userdata.txt", true))
            {
                file.WriteLine(writeData);
            }
            Close();
        }
        private bool isValidBirthDay(string day, int m, string year)
        {
            int[] dList = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int d, y;
            if(!int.TryParse(day, out d)||!int.TryParse(year, out y)) return false;     
            if (m < 0) return false;
            if (d > dList[m]||d<1)   return false;
            if (m == 1) //checking is leap year for febuary
            {
                bool l = isLeapYear(y);
                if (l && d>29)                
                    return false;    
                else if ((!l) && d > 28)              
                    return false;    
            }
            return true;
        }
        private bool isLeapYear(int y)
        {
            if (y % 400 == 0) return true;
            if (y % 100 == 0) return false;
            if (y % 4 == 0) return true;
            else return false;
        }
       private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void sexSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void birthdayBox_TextChanged(object sender, EventArgs e)
        {
            int d = 0;
            if ((!int.TryParse(birthdayBox.Text, out d)) && birthdayBox.Text != "")
            {
                MessageBox.Show("Birthday must be integer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                birthdayBox.Text = "";
                return;
            }
        }
        private void birthdayBox_click(object sender, EventArgs e)
        {
            birthdayBox.Text = "";
        }
        private void birthyearBox_click(object sender, EventArgs e)
        {
            birthyearBox.Text = "";
        }

        private void birthyearBox_TextChanged(object sender, EventArgs e)
        {
            int d;
            if ((!int.TryParse(birthyearBox.Text, out d)) && birthyearBox.Text != "")
            {
                MessageBox.Show("Birthyear must be integer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                birthyearBox.Text = "";
            }
        }
    }
}
