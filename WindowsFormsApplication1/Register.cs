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
//using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApplication1
{
    public partial class Register : Form
    {
        private PatientData pd;
        /*Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range xlRange;*/
        public Register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            pd = new PatientData(sexDefine(),nameBox.Text,surnameBox.Text);
            pd.setID(IDBox.Text);
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
            saveCSV(pd);
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
       /* private void saveExcel(PatientData pd)
        {
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (!File.Exists("C:\\Users\\Peerawut\\Documents\\userdata.xlsx"))
            {
                xlWorkBook = xlApp.Workbooks.Add("");
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.ActiveSheet;
                xlWorkSheet.Cells[ 1, 1] ="คำนำหน้าชื่อ";
                xlWorkSheet.Cells[1, 2] = "ชื่อ";
                xlWorkSheet.Cells[1, 3] = "นามสกุล";
                xlWorkSheet.Cells[1, 4] = "วันเกิด";
                xlWorkSheet.Cells[1, 5] = "เดือนเกิด";
                xlWorkSheet.Cells[1, 6] = "ปีเกิด (พ.ศ.)";
                xlWorkBook.SaveAs("C:\\Users\\Peerawut\\Documents\\userdata.xlsx");
                xlWorkBook.Close();
            }
            xlWorkBook = xlApp.Workbooks.Open("C:\\Users\\Peerawut\\Documents\\userdata.xlsx");          
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.ActiveSheet;
            xlRange = xlWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            int idx = xlRange.Row;
            xlWorkSheet.Cells[idx + 1, 1] = pd.getSex();
            xlWorkSheet.Cells[idx + 1, 2] = pd.getName();
            xlWorkSheet.Cells[idx + 1, 3] = pd.getSurname();
            xlWorkSheet.Cells[idx + 1, 4] = pd.getDay();
            xlWorkSheet.Cells[idx + 1, 5] = pd.getMonthName();
            xlWorkSheet.Cells[idx + 1, 6] = pd.getYear();
            xlWorkBook.Save();
            MessageBox.Show("บันทึกข้อมูลแล้ว", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            xlWorkBook.Close();
            xlApp.Quit();
        }*/
        private void saveCSV(PatientData pd)
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\userdata.csv"))
            {
                using (System.IO.StreamWriter file = new StreamWriter(@"C:\\Users\\Peerawut\\Documents\\userdata.csv",true, Encoding.UTF8))
                {
                    file.WriteLine("รหัส,คำนำหน้าชื่อ,ชื่อ,นามสกุล,วันเกิด,เดือนเกิด,ปีเกิด (พ.ศ.)");
                }
            }
            string input = pd.getID()+","+pd.getSex()+","+ pd.getName() + ","+ pd.getSurname() + ","+pd.getDay() + ","+ pd.getMonthName() + ","+ pd.getYear();
            using (StreamWriter file = new StreamWriter(Directory.GetCurrentDirectory() + "\\userdata.csv", true, Encoding.UTF8))
            {
                file.WriteLine(input);
            }
            MessageBox.Show("บันทึกข้อมูลแล้ว", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool checkData(PatientData pd)
        {
            if(pd.getID() == "")
            {
                MessageBox.Show("กรุณาใส่รหัสผู้ป่วย", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pd.getSex() == "")
            {
                MessageBox.Show("กรุณาระบุคำนำหน้าชื่อ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pd.getName() == "" || pd.getSurname() == "")
            {
                MessageBox.Show("ห้ามเว้นว่างชื่อหรือนามสกุล", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int[] dList = new int[13] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31,31 };
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
