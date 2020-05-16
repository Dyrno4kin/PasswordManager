using Controllers;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class FormGroup : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public int userId { set; get; }

        public int Id { set { id = value; } }

        private int? id;

        private readonly GroupController groupService;

        public FormGroup(GroupController groupService)
        {
            InitializeComponent();
            this.groupService = groupService;
        }

        private void FormGroup_Load(object sender, EventArgs e)
        {
            labelGroupUp.Text = "Add Group";
            textBoxGroupName.Text = "Group name";
            if (id.HasValue)
            {
                labelGroupUp.Text = "Edit Group";
                PasswordGroup passwordGroup = groupService.GetElement(id.Value);
                textBoxGroupName.Text = passwordGroup.GroupName;
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


        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxGroupName.Text == "Group name")
            {
                MyMessageBox.ShowMessage("Заполните название группы", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    groupService.UpdElement(new PasswordGroup
                    {
                        Id = id.Value,
                        UserId = userId,
                        GroupName = textBoxGroupName.Text
                    });
                }
                else
                {
                    groupService.AddElement(new PasswordGroup
                    {
                        UserId = userId,
                        GroupName = textBoxGroupName.Text
                    });
                }
                
                MyMessageBox.ShowMessage("Сохранение прошло успешно", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Question);
                Close();
            }
            catch (Exception)
            {
                MyMessageBox.ShowMessage("Такая группа уже существует", "Message",60, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
