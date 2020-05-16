namespace View
{
    partial class FormGroup
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelNameAccount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.panelCap = new System.Windows.Forms.Panel();
            this.labelGroupUp = new System.Windows.Forms.Label();
            this.labelSkip = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelCap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.labelNameAccount);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.panelLine1);
            this.panelMain.Controls.Add(this.textBoxGroupName);
            this.panelMain.Controls.Add(this.panelCap);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(465, 165);
            this.panelMain.TabIndex = 0;
            // 
            // labelNameAccount
            // 
            this.labelNameAccount.AutoSize = true;
            this.labelNameAccount.Font = new System.Drawing.Font("Arial", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameAccount.ForeColor = System.Drawing.Color.White;
            this.labelNameAccount.Location = new System.Drawing.Point(146, 76);
            this.labelNameAccount.Name = "labelNameAccount";
            this.labelNameAccount.Size = new System.Drawing.Size(79, 16);
            this.labelNameAccount.TabIndex = 33;
            this.labelNameAccount.Text = "Group name";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::View.Properties.Resources.groupPass;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(20, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 27;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 14.86792F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonSave.Location = new System.Drawing.Point(138, 104);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(301, 39);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Ok";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.White;
            this.panelLine1.Location = new System.Drawing.Point(139, 84);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(300, 1);
            this.panelLine1.TabIndex = 16;
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxGroupName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGroupName.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxGroupName.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGroupName.ForeColor = System.Drawing.Color.White;
            this.textBoxGroupName.Location = new System.Drawing.Point(139, 56);
            this.textBoxGroupName.MaxLength = 30;
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(300, 21);
            this.textBoxGroupName.TabIndex = 19;
            this.textBoxGroupName.Enter += new System.EventHandler(this.textBoxGroupName_Enter);
            this.textBoxGroupName.Leave += new System.EventHandler(this.textBoxGroupName_Leave);
            // 
            // panelCap
            // 
            this.panelCap.Controls.Add(this.labelGroupUp);
            this.panelCap.Controls.Add(this.labelSkip);
            this.panelCap.Controls.Add(this.labelExit);
            this.panelCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCap.Location = new System.Drawing.Point(0, 0);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(461, 26);
            this.panelCap.TabIndex = 3;
            this.panelCap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCap_MouseDown);
            this.panelCap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCap_MouseMove);
            // 
            // labelGroupUp
            // 
            this.labelGroupUp.AutoSize = true;
            this.labelGroupUp.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroupUp.ForeColor = System.Drawing.Color.White;
            this.labelGroupUp.Location = new System.Drawing.Point(4, 4);
            this.labelGroupUp.Name = "labelGroupUp";
            this.labelGroupUp.Size = new System.Drawing.Size(80, 18);
            this.labelGroupUp.TabIndex = 11;
            this.labelGroupUp.Text = "Group info";
            // 
            // labelSkip
            // 
            this.labelSkip.AutoSize = true;
            this.labelSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkip.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSkip.Image = global::View.Properties.Resources.minus;
            this.labelSkip.Location = new System.Drawing.Point(413, 4);
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
            this.labelExit.Location = new System.Drawing.Point(434, 4);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(25, 20);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "    ";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // FormGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 165);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGroup";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormGroup_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Label labelSkip;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelGroupUp;
        private System.Windows.Forms.Label labelNameAccount;
    }
}