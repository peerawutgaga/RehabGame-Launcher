﻿using System;
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
            string writeData = sexSelector.Text + " " + nameBox.Text+" "+surnameBox.Text+" "
                +birthdayBox.Text+" "+birthmonthSelector.Text+" "+birthyearBox.Text ; 
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\\WriteLines2.txt", true))
            {
                file.WriteLine(writeData);
            }
            Close();
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
           
        }
        private void birthdayBox_click(object sender, EventArgs e)
        {
            birthdayBox.Text = "";
        }
        private void birthyearBox_click(object sender, EventArgs e)
        {
            birthyearBox.Text = "";
        }
    }
}
