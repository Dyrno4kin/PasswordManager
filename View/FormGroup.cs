using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
        }

        #region UpPanel
        private void labelExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void panelCap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelCap_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        #region textBoxsLeave/Enter
        private void textBoxGroupName_Enter(object sender, EventArgs e)
        {
            if (textBoxGroupName.Text == "Group name")
            {
                textBoxGroupName.Text = "";
            }
        }
        private void textBoxGroupName_Leave(object sender, EventArgs e)
        {
            if (textBoxGroupName.Text == "")
            {
                textBoxGroupName.Text = "Group name";
            }
        }
        
        #endregion

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
