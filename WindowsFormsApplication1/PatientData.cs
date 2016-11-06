using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class PatientData
    {
        private string name,surname,birthmonthText,sex;
        private int birthday, birthmonthNum, birthyear;
        public PatientData(string sex,string name,string surname)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }
        public void setBirthDay(int d,int mIndex,int y)
        {
            string[] mList = new string[13] { "มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม","" };
            this.birthmonthNum = mIndex + 1;
            this.birthmonthText = mList[mIndex];
            this.birthday = d;
            this.birthyear = y;
        }
        public int getYear()
        {
            return birthyear;
        }
        public int getDay()
        {
            return birthday;
        }
        public int getMonth()
        {
            return birthmonthNum;
        }
        public string getMonthName()
        {
            return birthmonthText;
        }
        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }
        public string getSex()
        {
            return sex;
        }
        

    }
}