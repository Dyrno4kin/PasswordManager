using Controllers;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;
using View;

namespace ViewAuthorization
{
    public partial class FormVerification : Form
    {
        public string Email { get; set; }
        public string FIO { get; set; }
        public int Id { get; set; }
        public bool Registration { get; set; }
        int emailCode;
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SendEmailController sendEmailService;
        private readonly UserController userService;
        public FormVerification(SendEmailController sendEmailService, UserController userService)
        {
            InitializeComponent();
            this.sendEmailService = sendEmailService;
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
        private void textBoxCode_Enter(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "Enter code from email")
            {
                textBoxCode.Text = "";
            }
        }
        private void textBoxCode_Leave(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "")
            {
                textBoxCode.Text = "Enter code from email";
            }
        }
        #endregion

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxCode.Text == Convert.ToString(emailCode))
            {
                if(Registration)
                {
                    userService.ActivateAccount(new User
                    {
                        Id = Id,
                        Status = true
                    });
                    MyMessageBox.ShowMessage("Активация прошла успешно", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.Visible = false;
                var form = Container.Resolve<FormMain>();
                form.id = Id;
                MyMessageBox.ShowMessage("Добрый день " + FIO + "!", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Question);
                form.ShowDialog();
                Close();
            }
            else
            {
                MyMessageBox.ShowMessage("Неверный код подтверждения, попробуйте еще раз", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdateCode_Click(object sender, EventArgs e)
        {
            if (Registration)
            {
                Random rnd = new Random();
                emailCode = rnd.Next(1000, 9999);
                sendEmailService.SendEmail(Email, "Код подтверждения для активации аккаунта", "Код подтверждения: " + Convert.ToString(emailCode));
            }
            else
            {
                Random rnd = new Random();
                emailCode = rnd.Next(1000, 9999);
                sendEmailService.SendEmail(Email, "Код подтверждения для входа в систему", "Код подтверждения: " + Convert.ToString(emailCode));
            }
        }

        private void FormVerification_Load(object sender, EventArgs e)
        {
            if (Registration)
            {
                Random rnd = new Random();
                emailCode = rnd.Next(1000, 9999);
                sendEmailService.SendEmail(Email, "Код подтверждения для активации аккаунта", "Код подтверждения: " + Convert.ToString(emailCode));
            }
            else
            {
                Random rnd = new Random();
                emailCode = rnd.Next(1000, 9999);
                sendEmailService.SendEmail(Email, "Код подтверждения для входа в систему", "Код подтверждения: " + Convert.ToString(emailCode));
            }          
        }
    }
}
