using Controllers;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormAccount : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int groupId { set; get; }

        public int Id { set { id = value; } }

        private int? id;

        private readonly AccountController accountService;

        public FormAccount(AccountController accountService)
        {
            InitializeComponent();
            this.accountService = accountService;
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            labelUpInfo.Text = "Add Account";
            if (id.HasValue)
            {
                labelUpInfo.Text = "Edit Account";
                Account account = accountService.GetElement(id.Value);
                textNameAccount.Text = account.NameAccount;
                textBoxLogin.Text = account.LoginAccount;
                textBoxPass.Text = account.PasswordAccount;
                textBoxLink.Text = account.URL;
                textBoxComment.Text = account.Comment;
            }
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
        private void textBoxNameAccount_Enter(object sender, EventArgs e)
        {
            if (textNameAccount.Text == "Name account")
            {
                textNameAccount.Text = "";
            }
        }
        private void textBoxNameAccount_Leave(object sender, EventArgs e)
        {
            if (textNameAccount.Text == "")
            {
                textNameAccount.Text = "Name account";
            }
        }
        private void textBoxLink_Enter(object sender, EventArgs e)
        {
            if (textBoxLink.Text == "URL")
            {
                textBoxLink.Text = "";
            }
        }
        private void textBoxLink_Leave(object sender, EventArgs e)
        {
            if (textBoxLink.Text == "")
            {
                textBoxLink.Text = "URL";
            }
        }

        private void textBoxComment_Enter(object sender, EventArgs e)
        {
            if (textBoxComment.Text == "Comment")
            {
                textBoxComment.Text = "";
            }
        }

        private void textBoxComment_Leave(object sender, EventArgs e)
        {
            if (textBoxComment.Text == "")
            {
                textBoxComment.Text = "Comment";
            }
        }
        #endregion

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPasswordGenerator>();
            form.ShowDialog();
            textBoxPass.Text = form.returnPassword();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textNameAccount.Text == "Name account")
            {
                MyMessageBox.ShowMessage("Заполните название", "Message", 60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxLogin.Text == "Login")
            {
                MyMessageBox.ShowMessage("Заполните логин", "Message", 60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxPass.Text == "Password")
            {
                MyMessageBox.ShowMessage("Заполните пароль", "Message", 60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    accountService.UpdElement(new Account
                    {
                        Id = id.Value,
                        PasswordGroupId = groupId,
                        NameAccount = textNameAccount.Text,
                        LoginAccount = textBoxLogin.Text,
                        PasswordAccount = textBoxPass.Text,
                        URL = textBoxLink.Text,
                        Comment = textBoxComment.Text
                    });
                }
                else
                {
                    accountService.AddElement(new Account
                    {
                        PasswordGroupId = groupId,
                        NameAccount = textNameAccount.Text,
                        LoginAccount = textBoxLogin.Text,
                        PasswordAccount = textBoxPass.Text,
                        URL = textBoxLink.Text,
                        Comment = textBoxComment.Text
                    });
                }

                MyMessageBox.ShowMessage("Сохранение прошло успешно", "Message", 60, MessageBoxButtons.OK, MessageBoxIcon.Question);
                Close();
            }
            catch (Exception)
            {
                MyMessageBox.ShowMessage("Такая учетная запись уже сущетвует", "Message", 60, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
