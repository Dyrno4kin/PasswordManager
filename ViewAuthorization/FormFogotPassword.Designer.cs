namespace ViewAuthorization
{
    partial class FormFogotPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCap = new System.Windows.Forms.Panel();
            this.labelSkip = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSendPass = new System.Windows.Forms.Button();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panelCap);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBoxEmail);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.buttonSendPass);
            this.panel1.Controls.Add(this.panelLine1);
            this.panel1.Controls.Add(this.pictureBoxLogin);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 271);
            this.panel1.TabIndex = 0;
            // 
            // panelCap
            // 
            this.panelCap.Controls.Add(this.labelSkip);
            this.panelCap.Controls.Add(this.labelExit);
            this.panelCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCap.Location = new System.Drawing.Point(-62, 1);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(424, 32);
            this.panelCap.TabIndex = 22;
            this.panelCap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCap_MouseDown);
            this.panelCap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCap_MouseMove);
            // 
            // labelSkip
            // 
            this.labelSkip.AutoSize = true;
            this.labelSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSkip.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSkip.Image = global::ViewAuthorization.Properties.Resources.minus;
            this.labelSkip.Location = new System.Drawing.Point(374, 4);
            this.labelSkip.Name = "labelSkip";
            this.labelSkip.Size = new System.Drawing.Size(17, 20);
            this.labelSkip.TabIndex = 9;
            this.labelSkip.Text = "  ";
            this.labelSkip.Click += new System.EventHandler(this.labelSkip_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Image = global::ViewAuthorization.Properties.Resources.close;
            this.labelExit.Location = new System.Drawing.Point(395, 4);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(25, 20);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "    ";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(47, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 1);
            this.panel2.TabIndex = 11;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Image = global::ViewAuthorization.Properties.Resources.email;
            this.pictureBoxEmail.Location = new System.Drawing.Point(47, 135);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmail.TabIndex = 21;
            this.pictureBoxEmail.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(98, 151);
            this.textBoxEmail.MaxLength = 40;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(218, 21);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // buttonSendPass
            // 
            this.buttonSendPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            this.buttonSendPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendPass.Font = new System.Drawing.Font("Arial", 14.86792F);
            this.buttonSendPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonSendPass.Location = new System.Drawing.Point(46, 198);
            this.buttonSendPass.Name = "buttonSendPass";
            this.buttonSendPass.Size = new System.Drawing.Size(270, 48);
            this.buttonSendPass.TabIndex = 1;
            this.buttonSendPass.Text = "Send password on email";
            this.buttonSendPass.UseVisualStyleBackColor = false;
            this.buttonSendPass.Click += new System.EventHandler(this.buttonSendPass_Click);
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.White;
            this.panelLine1.Location = new System.Drawing.Point(47, 96);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(270, 1);
            this.panelLine1.TabIndex = 14;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::ViewAuthorization.Properties.Resources.log;
            this.pictureBoxLogin.Location = new System.Drawing.Point(47, 46);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 15;
            this.pictureBoxLogin.TabStop = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxLogin.Location = new System.Drawing.Point(98, 68);
            this.textBoxLogin.MaxLength = 25;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(219, 21);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.Text = "Login";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // FormFogotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 271);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFogotPassword";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFogotPassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSendPass;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Label labelSkip;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}