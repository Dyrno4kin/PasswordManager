using Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormPasswordGenerator : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly PasswordGeneratorController genecatorService;

        public FormPasswordGenerator(PasswordGeneratorController genecatorService)
        {
            InitializeComponent();
            labelCurrentValue.Text = String.Format("Password length: {0}", trackBar1.Value);
            this.genecatorService = genecatorService;
            textBoxPass.Text = genecatorService.generatePassword(uppercaseBox.Checked, lowercaseBox.Checked, numericBox.Checked, specialBox.Checked, Convert.ToInt32(trackBar1.Value));
            Clipboard.SetText(textBoxPass.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelCurrentValue.Text = String.Format("Password length: {0}", trackBar1.Value);
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

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBoxPass.Text = genecatorService.generatePassword(uppercaseBox.Checked,lowercaseBox.Checked, numericBox.Checked, specialBox.Checked, Convert.ToInt32(trackBar1.Value));
            Clipboard.SetText(textBoxPass.Text);
            toolTip1.Show("Пароль скопирован в буфер обмена", buttonGenerate);
        }
    }
}
