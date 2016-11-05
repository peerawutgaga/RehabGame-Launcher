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
        private PatientData pd;
        public Register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            pd = new PatientData(sexDefine(),nameBox.Text,surnameBox.Text);
            if (!checkBirthdayFormat())
            {
                return;
            }
            int d = int.Parse(birthdayBox.Text);
            int y = int.Parse(birthyearBox.Text);
            pd.setBirthDay(d, birthmonthSelector.SelectedIndex, y);
            if (!checkData(pd))
            {
                return;
            }
            Close();
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

        private void birthdayBox_TextChanged(object sender, EventArgs e)
        {
            int d = 0;
            if ((!int.TryParse(birthdayBox.Text, out d)) && birthdayBox.Text != "")
            {
                MessageBox.Show("วันที่ต้องเป็นตัวเลขเท่านั้น", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ปีเกิดต้องเป็นจำนวนเต็มเท่านั้น", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                birthyearBox.Text = "";
            }
        }
        private string sexDefine()
        {
            if (mr.Checked)
            {
                return ("นาย");
            }
            if (ms.Checked)
            {
                return ("นางสาว");
            }
            if (mrs.Checked)
            {
                return ("นาง");
            }
           else
            {
                return "";
            }
        }
        private void saveData()
        {
            
        }
        private bool checkData(PatientData pd)
        {
            string sex = pd.getSex() ;
            if (sex == "")
            {
                MessageBox.Show("กรุณาระบุคำนำหน้าชื่อ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pd.getName() == "" || pd.getSurname() == "")
            {
                MessageBox.Show("ห้ามเว้นว่างชื่อหรือนามสกุล", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int[] dList = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (pd.getDay() > dList[pd.getMonth()] )
            {
                MessageBox.Show("วันเกิดที่กรอกเป็นไปไม่ได้", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pd.getYear() < 2430)
            {
                MessageBox.Show("ปีเกิดที่กรอกเป็นไปไม่ได้", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pd.getMonth() == 1) //checking is leap year for febuary
            {
                int y = pd.getYear() - 543;
                bool leap = isLeapYear(y);
                if (leap && pd.getDay() > 29)
                {
                    MessageBox.Show("วันเดือนปีเกิดผิดรูปแบบ leap 1", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if ((!leap) && pd.getDay() > 28)
                {
                    MessageBox.Show("วันเดือนปีเกิดผิดรูปแบบ leap 2", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true; 
        }
        private bool checkBirthdayFormat()
        {
            int d, y;
            if (!int.TryParse(birthdayBox.Text, out d))
            {
                MessageBox.Show("กรุณากรอกวันเกิด", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (birthmonthSelector.SelectedIndex < 0)
            {
                MessageBox.Show("กรุณาเลือกเดือนเกิด", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(birthyearBox.Text, out y))
            {
                MessageBox.Show("กรุณากรอกปีเกิด (พ.ศ.)", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
