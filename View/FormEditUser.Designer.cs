namespace View
{
    partial class FormEditUser
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
            this.twoStepVerificationBox = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonGeneratePassword = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panelCap = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPassChar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.labelSkip = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.buttonPassChar);
            this.panelMain.Controls.Add(this.twoStepVerificationBox);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.buttonGeneratePassword);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.textBoxFIO);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.pictureBoxEmail);
            this.panelMain.Controls.Add(this.textBoxEmail);
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.panelLine2);
            this.panelMain.Controls.Add(this.pictureBoxPass);
            this.panelMain.Controls.Add(this.textBoxPass);
            this.panelMain.Controls.Add(this.panelLine1);
            this.panelMain.Controls.Add(this.pictureBoxLogin);
            this.panelMain.Controls.Add(this.textBoxLogin);
            this.panelMain.Controls.Add(this.panelCap);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(573, 440);
            this.panelMain.TabIndex = 0;
            // 
            // twoStepVerificationBox
            // 
            this.twoStepVerificationBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.twoStepVerificationBox.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoStepVerificationBox.ForeColor = System.Drawing.Color.White;
            this.twoStepVerificationBox.Location = new System.Drawing.Point(168, 340);
            this.twoStepVerificationBox.Name = "twoStepVerificationBox";
            this.twoStepVerificationBox.Size = new System.Drawing.Size(324, 28);
            this.twoStepVerificationBox.TabIndex = 1015;
            this.twoStepVerificationBox.Text = "Use TwoStep Verification on Email";
            this.twoStepVerificationBox.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(172, 369);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 1);
            this.panel4.TabIndex = 28;
            // 
            // buttonGeneratePassword
            // 
            this.buttonGeneratePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonGeneratePassword.FlatAppearance.BorderSize = 0;
            this.buttonGeneratePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonGeneratePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneratePassword.Font = new System.Drawing.Font("Arial", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGeneratePassword.ForeColor = System.Drawing.Color.White;
            this.buttonGeneratePassword.Location = new System.Drawing.Point(170, 250);
            this.buttonGeneratePassword.Name = "buttonGeneratePassword";
            this.buttonGeneratePassword.Size = new System.Drawing.Size(377, 24);
            this.buttonGeneratePassword.TabIndex = 22;
            this.buttonGeneratePassword.Text = "Generate password";
            this.buttonGeneratePassword.UseVisualStyleBackColor = true;
            this.buttonGeneratePassword.Click += new System.EventHandler(this.buttonGeneratePassword_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(172, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 1);
            this.panel2.TabIndex = 25;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxFIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFIO.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxFIO.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFIO.ForeColor = System.Drawing.Color.White;
            this.textBoxFIO.Location = new System.Drawing.Point(224, 67);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(323, 21);
            this.textBoxFIO.TabIndex = 18;
            this.textBoxFIO.Text = "Full name";
            this.textBoxFIO.Enter += new System.EventHandler(this.textBoxFIO_Enter);
            this.textBoxFIO.Leave += new System.EventHandler(this.textBoxFIO_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(172, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 1);
            this.panel1.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(223, 289);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(324, 21);
            this.textBoxEmail.TabIndex = 23;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 14.86792F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonSave.Location = new System.Drawing.Point(171, 381);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(376, 37);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelLine2
            // 
            this.panelLine2.BackColor = System.Drawing.Color.White;
            this.panelLine2.Location = new System.Drawing.Point(172, 247);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(375, 1);
            this.panelLine2.TabIndex = 14;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPass.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.ForeColor = System.Drawing.Color.White;
            this.textBoxPass.Location = new System.Drawing.Point(223, 218);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(324, 21);
            this.textBoxPass.TabIndex = 21;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.White;
            this.panelLine1.Location = new System.Drawing.Point(172, 168);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(375, 1);
            this.panelLine1.TabIndex = 16;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxLogin.Location = new System.Drawing.Point(223, 139);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(324, 21);
            this.textBoxLogin.TabIndex = 19;
            this.textBoxLogin.Text = "Login";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // panelCap
            // 
            this.panelCap.Controls.Add(this.label1);
            this.panelCap.Controls.Add(this.labelSkip);
            this.panelCap.Controls.Add(this.labelExit);
            this.panelCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCap.Location = new System.Drawing.Point(0, 0);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(569, 26);
            this.panelCap.TabIndex = 3;
            this.panelCap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCap_MouseDown);
            this.panelCap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCap_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "User info";
            // 
            // buttonPassChar
            // 
            this.buttonPassChar.BackgroundImage = global::View.Properties.Resources.eye;
            this.buttonPassChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPassChar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPassChar.FlatAppearance.BorderSize = 0;
            this.buttonPassChar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPassChar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPassChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPassChar.Image = global::View.Properties.Resources.eye;
            this.buttonPassChar.Location = new System.Drawing.Point(510, 214);
            this.buttonPassChar.Name = "buttonPassChar";
            this.buttonPassChar.Size = new System.Drawing.Size(28, 28);
            this.buttonPassChar.TabIndex = 1016;
            this.buttonPassChar.UseVisualStyleBackColor = false;
            this.buttonPassChar.Click += new System.EventHandler(this.buttonPassChar_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::View.Properties.Resources.user;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(21, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 128);
            this.panel3.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.passport;
            this.pictureBox1.Location = new System.Drawing.Point(167, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Image = global::View.Properties.Resources.email;
            this.pictureBoxEmail.Location = new System.Drawing.Point(172, 272);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmail.TabIndex = 24;
            this.pictureBoxEmail.TabStop = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = global::View.Properties.Resources.pass;
            this.pictureBoxPass.Location = new System.Drawing.Point(172, 192);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPass.TabIndex = 20;
            this.pictureBoxPass.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::View.Properties.Resources.log;
            this.pictureBoxLogin.Location = new System.Drawing.Point(172, 115);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 17;
            this.pictureBoxLogin.TabStop = false;
            // 
            // labelSkip
            // 
            this.labelSkip.AutoSize = true;
            this.labelSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkip.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSkip.Image = global::View.Properties.Resources.minus;
            this.labelSkip.Location = new System.Drawing.Point(520, 4);
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
            this.labelExit.Location = new System.Drawing.Point(541, 4);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(25, 20);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "    ";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 440);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditUser";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormEditUser_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Label labelSkip;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Button buttonGeneratePassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox twoStepVerificationBox;
        private System.Windows.Forms.Button buttonPassChar;
    }
}