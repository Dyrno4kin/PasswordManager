using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly GroupController groupService;

        private readonly AccountController accountService;

        public int id { get; set; }

        public int groupId { get; set; }

        public FormMain(GroupController groupService, AccountController accountService)
        {
            InitializeComponent();
            this.groupService = groupService;
            this.accountService = accountService;
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new Cols());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadGroups();
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

        #region Edit User
        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormEditUser>();
            form.id = id;
            form.ShowDialog();
        }
        #endregion

        #region CRUD Group

        private void LoadGroups()
        {
            try
            {
                List<PasswordGroup> list = groupService.GetListGroup(id);
                if (list != null)
                {
                    dataGridViewGroups.DataSource = list;
                    dataGridViewGroups.Columns[0].Visible = false;
                    dataGridViewGroups.Columns[2].Visible = false;
                    dataGridViewGroups.Columns[3].Visible = false;
                    dataGridViewGroups.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormGroup>();
            form.userId = id;
            form.ShowDialog();
            LoadGroups();
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormGroup>();
            form.userId = id;
            form.Id = Convert.ToInt32(dataGridViewGroups.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            LoadGroups();
        }

        private void buttonDelGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 1)
            {
                if (MyMessageBox.ShowMessage("Удалить запись?", "Message",60, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idDel = Convert.ToInt32(dataGridViewGroups.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        groupService.DelElement(idDel);
                        MyMessageBox.ShowMessage("Успешно!", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception)
                    {
                        MyMessageBox.ShowMessage("Ошибка", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    LoadGroups();
                }
            }
        }
        #endregion 

        #region CRUD Accounts
        private void LoadAccounts(int GroupId)
        {
            try
            {
                List<Account> list = accountService.GetListAccount(GroupId);
                if (list != null)
                {
                    dataGridViewAccounts.DataSource = list;
                    dataGridViewAccounts.Columns[0].Visible = false;
                    dataGridViewAccounts.Columns[3].Visible = false;
                    dataGridViewAccounts.Columns[4].Visible = false;
                    dataGridViewAccounts.Columns[5].Visible = false;
                    dataGridViewAccounts.Columns[6].Visible = false;
                    dataGridViewAccounts.Columns[7].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAccount>();
            form.groupId = Convert.ToInt32(dataGridViewGroups.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            LoadAccounts(groupId);
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormAccount>();
            form.groupId = Convert.ToInt32(dataGridViewGroups.SelectedRows[0].Cells[0].Value);
            form.Id = Convert.ToInt32(dataGridViewAccounts.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            LoadAccounts(groupId);
        }

        private void buttonDelAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccounts.SelectedRows.Count == 1)
            {
                if (MyMessageBox.ShowMessage("Удалить запись?", "Message", 60, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idDel = Convert.ToInt32(dataGridViewAccounts.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        accountService.DelElement(idDel);
                        MyMessageBox.ShowMessage("Успешно!", "Message", 60, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception)
                    {
                        MyMessageBox.ShowMessage("Ошибка", "Message", 60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    LoadAccounts(groupId);
                }
            }
        }

        private void dataGridViewGroups_SelectionChanged(object sender, EventArgs e)
        {
            groupId = Convert.ToInt32(dataGridViewGroups.CurrentRow.Cells[0].Value);
            if (dataGridViewGroups.SelectedRows.Count == 1)
            {
                try
                {
                    LoadAccounts(groupId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
