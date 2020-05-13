using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class MessegeBoxOk : Form
    {
        public MessegeBoxOk()
        {
            InitializeComponent();
            textBoxMessage.SendToBack();

        }

        public Image MessageIcon
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public string Message
        {
            get { return textBoxMessage.Text; }
            set { textBoxMessage.Text = value; }
            
        }

        public int LocationY
        {
            set { textBoxMessage.Location = new Point(100, value); }
        }
    }
}
