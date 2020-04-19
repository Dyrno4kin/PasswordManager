using Controllers;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;
using System.Text.RegularExpressions;

namespace View
{
    public partial class FormEditUser : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly UserController userService;
        public int id { get; set; }
        public FormEditUser(UserController userService)
        {
            InitializeComponent();
            this.userService = userService;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFIO.Text == "Full name")
            {
                MyMessageBox.ShowMessage("Заполните ФИО", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxLogin.Text == "Login")
            {
                MyMessageBox.ShowMessage("Заполните логин", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxPass.Text == "Password")
            {
                MyMessageBox.ShowMessage("Придумайте пароль", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxEmail.Text == "Email")
            {
                MyMessageBox.ShowMessage("Заполните Email", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z0-9_.+-]+\@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                MyMessageBox.ShowMessage("Неверный формат электронной почты", "Message", 60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Regex.IsMatch(textBoxPass.Text, @"^(?=.*[a-z])(?=.*[0-9])\S{8,26}$"))
            {
                try
                {
                    userService.UpdElement(new User
                    {
                        Id = id,
                        FIO = textBoxFIO.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPass.Text,
                        Email = textBoxEmail.Text,
                        Authentication = twoStepVerificationBox.Checked
                    });
                    MyMessageBox.ShowMessage("Сохранение прошло успешно", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Question);

                    Close();
                }
                catch (Exception)
                {
                    MyMessageBox.ShowMessage("Уже есть такое ФИО или логин", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Пароль должен содержать от 8 до 26 символов и включать в себя символы и цифры", "Message",26, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            User user = userService.GetElement(id);
            textBoxFIO.Text = user.FIO;
            textBoxLogin.Text = user.Login;
            textBoxPass.Text = user.Password;
            textBoxEmail.Text = user.Email;
            twoStepVerificationBox.Checked = user.Authentication;

            textBoxPass.UseSystemPasswordChar = true;
        }

        bool btn_flag = false; 
        private void buttonPassChar_Click(object sender, EventArgs e)
        {
            if (!btn_flag)
            {
                textBoxPass.UseSystemPasswordChar = false;
                btn_flag = true;
                buttonPassChar.BackgroundImage = Properties.Resources.noeye;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                btn_flag = false;
                buttonPassChar.BackgroundImage = Properties.Resources.eye;
            }
        }

    }
}
