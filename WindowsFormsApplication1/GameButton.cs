using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class GameButton : Button
    {

        public GameButton(string v)  : base()
        {
            this.Name = v;
            this.Text = v;
        }
    }
}