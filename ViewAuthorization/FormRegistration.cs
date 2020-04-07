using Controllers;
using Models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Unity;

namespace ViewAuthorization
{
    public partial class FormRegistration : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UserController userService;

        public FormRegistration(UserController userService)
        {
            InitializeComponent();
            this.userService = userService;
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
        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Password")
            {
                textBoxPass.Text = "";
            }
        }
        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "Password";
            }
        }
        private void textBoxFIO_Enter(object sender, EventArgs e)
        {
            if (textBoxFIO.Text == "Full name")
            {
                textBoxFIO.Text = "";
            }
        }
        private void textBoxFIO_Leave(object sender, EventArgs e)
        {
            if (textBoxFIO.Text == "")
            {
                textBoxFIO.Text = "Full name";
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

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPasswordGenerator>();
            form.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxFIO.Text == "Full name")
            {
                MyMessageBox.ShowMessage("Заполните ФИО", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxLogin.Text == "Login")
            {
                MyMessageBox.ShowMessage("Заполните логин", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxPass.Text == "Password")
            {
                MyMessageBox.ShowMessage("Придумайте пароль", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxEmail.Text == "Email")
            {
                MyMessageBox.ShowMessage("Заполните Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Regex.IsMatch(textBoxEmail.Text, @"^[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}"))
            {
                MyMessageBox.ShowMessage("Неверный формат электронной почты", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Regex.IsMatch(textBoxPass.Text, @"^(?=.*[a-z])(?=.*[0-9])\S{8,26}$"))
            {
                try
                {
                    userService.AddElement(new User
                    {
                        FIO = textBoxFIO.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPass.Text,
                        Email = textBoxEmail.Text,
                        Status = false
                    });
                    MyMessageBox.ShowMessage("Регистрация прошла успешно, активируйте учетную запись с помощью кода отправленного на почту", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    User view = userService.GetElement(textBoxLogin.Text, textBoxPass.Text);
                    var form = Container.Resolve<FormVerification>();
                    form.Id = view.Id;
                    form.Email = view.Email;
                    form.FIO = view.FIO;
                    form.Registration = true;
                    form.ShowDialog();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Пароль должен содержать от 8 до 26 символов и включать в себя символы и цифры", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }      
        }
    }
}
