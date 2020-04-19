using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class MessegeBoxYesNo : Form
    {
        public MessegeBoxYesNo()
        {
            InitializeComponent();
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
    }
}
