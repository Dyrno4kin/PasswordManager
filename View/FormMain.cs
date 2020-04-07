using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class FormMain : Form
    {
        public int id { get; set; }

        public FormMain()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new Cols());
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

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            dataGridViewGroups.Columns.Add("Group name", "Название группы");
            dataGridViewGroups.Rows.Add("Group1");
            dataGridViewGroups.Rows.Add("Group2");
            dataGridViewGroups.Rows.Add("Group3");
            dataGridViewGroups.Rows.Add("Group4");
            dataGridViewGroups.Rows.Add("Group5");
            dataGridViewGroups.Rows.Add("Group6");


            dataGridViewAccounts.Columns.Add("Accaunt name", "Account name");
            dataGridViewAccounts.Rows.Add("Account1");
            dataGridViewAccounts.Rows.Add("Account2");
            dataGridViewAccounts.Rows.Add("Account3");
            dataGridViewAccounts.Rows.Add("Account4");
            dataGridViewAccounts.Rows.Add("Account5");

        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            FormGroup formGroup = new FormGroup();
            formGroup.ShowDialog();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new FormEditUser();
            formEditUser.ShowDialog();
        }
    }
}
