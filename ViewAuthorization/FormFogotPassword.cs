using Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;
using View;

namespace ViewAuthorization
{
    public partial class FormFogotPassword : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly UserController userController;

        public FormFogotPassword(UserController userController)
        {
            InitializeComponent();
            this.userController = userController;
        }

        #region UpPanel
        private void labelExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void labelSkip_Click(object sender, EventArgs e)
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
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Login")
            {
                textBoxLogin.Text = "";
            }
        }
        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Login";
            }
        }
        
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
            }
        }
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
            }
        }
        #endregion

        private void buttonSendPass_Click(object sender, EventArgs e)
        {
            try
            {
                userController.ResetPassword(textBoxLogin.Text, textBoxEmail.Text);
                Close();
                MyMessageBox.ShowMessage("Пароль отправлен на почту: "+textBoxEmail.Text, "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch
            {
                MyMessageBox.ShowMessage("Неверный логин или Email", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
