using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class GameButton : Button
    {
        private string path = Directory.GetCurrentDirectory();
        public GameButton(string v)  : base()
        {
            this.Name = v;
            this.Text = v;
            path += "\\Apps\\" + v + "\\" + v + ".exe";
        }
        public string GetPath()
        {
            return path;
        }
    }
}