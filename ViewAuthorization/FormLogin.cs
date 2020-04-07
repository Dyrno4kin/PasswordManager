using Controllers;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace ViewAuthorization
{
    public partial class FormLogin : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UserController userService;
        public FormLogin(UserController userService)
        {
            InitializeComponent();
            this.userService = userService;
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
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
            if(e.Button == MouseButtons.Left)
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

        #region TextBoxsLeave/Enter
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == "Login")
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

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Password") 
            {
                textBoxPass.UseSystemPasswordChar = true;
                textBoxPass.Text = "";
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.UseSystemPasswordChar = false;
                textBoxPass.Text = "Password";
            }
        }
        #endregion

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var form = Container.Resolve<FormRegistration>();
            form.ShowDialog();
            this.Visible = true;
        }

        private void buttonFogot_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormFogotPassword>();
            form.ShowDialog();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Login")
            {
                MyMessageBox.ShowMessage("Заполните логин", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxPass.Text == "Password")
            {
                MyMessageBox.ShowMessage("Заполните пароль", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                User view = userService.GetElement(textBoxLogin.Text, textBoxPass.Text);
                var form = Container.Resolve<FormVerification>();
                if (view.Status == false)
                {
                    MyMessageBox.ShowMessage("Учетная запись не активированна, пожалуйста активируйте учетную запись с помощью кода отправленного на почту", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.Registration = true;
                }            
                form.Id = view.Id;
                form.Email = view.Email;
                form.FIO = view.FIO;
                form.ShowDialog();
            }
            catch (Exception)
            {
                MyMessageBox.ShowMessage("Неверный логин или пароль", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBoxLogin.Text = "Login";
            textBoxPass.Text = "Password";
            return;
        }
    }
}
