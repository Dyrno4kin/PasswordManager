namespace View
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCap = new System.Windows.Forms.Panel();
            this.labelSkip = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.groupBoxAccounts = new System.Windows.Forms.GroupBox();
            this.buttonDelAccount = new System.Windows.Forms.Button();
            this.buttonEditAccount = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonDelGroup = new System.Windows.Forms.Button();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.panelCap.SuspendLayout();
            this.groupBoxAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem1});
            менюToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            менюToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            менюToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            менюToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            менюToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.редактироватьToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.редактироватьToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.редактироватьToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0);
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(193, 24);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelMain.Controls.Add(this.panelCap);
            this.panelMain.Controls.Add(this.groupBoxAccounts);
            this.panelMain.Controls.Add(this.groupBox);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 485);
            this.panelMain.TabIndex = 0;
            // 
            // panelCap
            // 
            this.panelCap.Controls.Add(this.labelSkip);
            this.panelCap.Controls.Add(this.labelExit);
            this.panelCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCap.Location = new System.Drawing.Point(69, 3);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(729, 26);
            this.panelCap.TabIndex = 3;
            this.panelCap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCap_MouseDown);
            this.panelCap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCap_MouseMove);
            // 
            // labelSkip
            // 
            this.labelSkip.AutoSize = true;
            this.labelSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkip.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSkip.Image = global::View.Properties.Resources.minus;
            this.labelSkip.Location = new System.Drawing.Point(680, 4);
            this.labelSkip.Name = "labelSkip";
            this.labelSkip.Size = new System.Drawing.Size(17, 20);
            this.labelSkip.TabIndex = 9;
            this.labelSkip.Text = "  ";
            this.labelSkip.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Image = global::View.Properties.Resources.close;
            this.labelExit.Location = new System.Drawing.Point(701, 4);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(25, 20);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "    ";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // groupBoxAccounts
            // 
            this.groupBoxAccounts.Controls.Add(this.buttonDelAccount);
            this.groupBoxAccounts.Controls.Add(this.buttonEditAccount);
            this.groupBoxAccounts.Controls.Add(this.buttonAddAccount);
            this.groupBoxAccounts.Controls.Add(this.dataGridViewAccounts);
            this.groupBoxAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAccounts.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAccounts.ForeColor = System.Drawing.Color.White;
            this.groupBoxAccounts.Location = new System.Drawing.Point(272, 32);
            this.groupBoxAccounts.Name = "groupBoxAccounts";
            this.groupBoxAccounts.Size = new System.Drawing.Size(516, 441);
            this.groupBoxAccounts.TabIndex = 2;
            this.groupBoxAccounts.TabStop = false;
            this.groupBoxAccounts.Text = "Учетные записи";
            // 
            // buttonDelAccount
            // 
            this.buttonDelAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonDelAccount.BackgroundImage = global::View.Properties.Resources.deleteGreen;
            this.buttonDelAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonDelAccount.FlatAppearance.BorderSize = 0;
            this.buttonDelAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonDelAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonDelAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelAccount.ForeColor = System.Drawing.Color.White;
            this.buttonDelAccount.Location = new System.Drawing.Point(89, 400);
            this.buttonDelAccount.Name = "buttonDelAccount";
            this.buttonDelAccount.Size = new System.Drawing.Size(32, 32);
            this.buttonDelAccount.TabIndex = 2;
            this.buttonDelAccount.UseVisualStyleBackColor = false;
            this.buttonDelAccount.Click += new System.EventHandler(this.buttonDelAccount_Click);
            // 
            // buttonEditAccount
            // 
            this.buttonEditAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEditAccount.BackgroundImage = global::View.Properties.Resources.editGreen;
            this.buttonEditAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEditAccount.FlatAppearance.BorderSize = 0;
            this.buttonEditAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEditAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditAccount.ForeColor = System.Drawing.Color.White;
            this.buttonEditAccount.Location = new System.Drawing.Point(49, 400);
            this.buttonEditAccount.Name = "buttonEditAccount";
            this.buttonEditAccount.Size = new System.Drawing.Size(32, 32);
            this.buttonEditAccount.TabIndex = 2;
            this.buttonEditAccount.UseVisualStyleBackColor = false;
            this.buttonEditAccount.Click += new System.EventHandler(this.buttonEditAccount_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAddAccount.BackgroundImage = global::View.Properties.Resources.addGreen;
            this.buttonAddAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAddAccount.FlatAppearance.BorderSize = 0;
            this.buttonAddAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAddAccount.Location = new System.Drawing.Point(9, 400);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(32, 32);
            this.buttonAddAccount.TabIndex = 1;
            this.buttonAddAccount.UseVisualStyleBackColor = false;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // dataGridViewAccounts
            // 
            this.dataGridViewAccounts.AllowUserToAddRows = false;
            this.dataGridViewAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAccounts.AllowUserToResizeColumns = false;
            this.dataGridViewAccounts.AllowUserToResizeRows = false;
            this.dataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridViewAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAccounts.CausesValidation = false;
            this.dataGridViewAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameAccount,
            this.URL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccounts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccounts.EnableHeadersVisualStyles = false;
            this.dataGridViewAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridViewAccounts.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewAccounts.MultiSelect = false;
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.ReadOnly = true;
            this.dataGridViewAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAccounts.RowHeadersVisible = false;
            this.dataGridViewAccounts.RowHeadersWidth = 45;
            this.dataGridViewAccounts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccounts.ShowCellErrors = false;
            this.dataGridViewAccounts.ShowCellToolTips = false;
            this.dataGridViewAccounts.ShowEditingIcon = false;
            this.dataGridViewAccounts.ShowRowErrors = false;
            this.dataGridViewAccounts.Size = new System.Drawing.Size(504, 372);
            this.dataGridViewAccounts.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonDelGroup);
            this.groupBox.Controls.Add(this.buttonEditGroup);
            this.groupBox.Controls.Add(this.buttonAddGroup);
            this.groupBox.Controls.Add(this.dataGridViewGroups);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(12, 32);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(234, 441);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Группы паролей";
            // 
            // buttonDelGroup
            // 
            this.buttonDelGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonDelGroup.BackgroundImage = global::View.Properties.Resources.deleteGreen;
            this.buttonDelGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonDelGroup.FlatAppearance.BorderSize = 0;
            this.buttonDelGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonDelGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonDelGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelGroup.ForeColor = System.Drawing.Color.White;
            this.buttonDelGroup.Location = new System.Drawing.Point(89, 400);
            this.buttonDelGroup.Name = "buttonDelGroup";
            this.buttonDelGroup.Size = new System.Drawing.Size(32, 32);
            this.buttonDelGroup.TabIndex = 2;
            this.buttonDelGroup.UseVisualStyleBackColor = false;
            this.buttonDelGroup.Click += new System.EventHandler(this.buttonDelGroup_Click);
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEditGroup.BackgroundImage = global::View.Properties.Resources.editGreen;
            this.buttonEditGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEditGroup.FlatAppearance.BorderSize = 0;
            this.buttonEditGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEditGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonEditGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditGroup.ForeColor = System.Drawing.Color.White;
            this.buttonEditGroup.Location = new System.Drawing.Point(49, 400);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(32, 32);
            this.buttonEditGroup.TabIndex = 2;
            this.buttonEditGroup.UseVisualStyleBackColor = false;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAddGroup.BackgroundImage = global::View.Properties.Resources.addGreen;
            this.buttonAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAddGroup.FlatAppearance.BorderSize = 0;
            this.buttonAddGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAddGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGroup.ForeColor = System.Drawing.Color.White;
            this.buttonAddGroup.Location = new System.Drawing.Point(9, 400);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(32, 32);
            this.buttonAddGroup.TabIndex = 1;
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.AllowUserToResizeColumns = false;
            this.dataGridViewGroups.AllowUserToResizeRows = false;
            this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroups.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridViewGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroups.CausesValidation = false;
            this.dataGridViewGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGroups.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewGroups.EnableHeadersVisualStyles = false;
            this.dataGridViewGroups.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridViewGroups.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewGroups.MultiSelect = false;
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewGroups.RowHeadersVisible = false;
            this.dataGridViewGroups.RowHeadersWidth = 45;
            this.dataGridViewGroups.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroups.ShowCellErrors = false;
            this.dataGridViewGroups.ShowCellToolTips = false;
            this.dataGridViewGroups.ShowEditingIcon = false;
            this.dataGridViewGroups.ShowRowErrors = false;
            this.dataGridViewGroups.Size = new System.Drawing.Size(222, 372);
            this.dataGridViewGroups.TabIndex = 0;
            this.dataGridViewGroups.SelectionChanged += new System.EventHandler(this.dataGridViewGroups_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(74, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NameAccount
            // 
            this.NameAccount.HeaderText = "Name Account";
            this.NameAccount.MinimumWidth = 6;
            this.NameAccount.Name = "NameAccount";
            this.NameAccount.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            this.groupBoxAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.Button buttonDelGroup;
        private System.Windows.Forms.GroupBox groupBoxAccounts;
        private System.Windows.Forms.Button buttonDelAccount;
        private System.Windows.Forms.Button buttonEditAccount;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Label labelSkip;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
    }
}