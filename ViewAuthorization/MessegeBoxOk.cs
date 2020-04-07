using System.Drawing;
using System.Windows.Forms;

namespace ViewAuthorization
{
    public partial class MessegeBoxOk : Form
    {
        public MessegeBoxOk()
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
