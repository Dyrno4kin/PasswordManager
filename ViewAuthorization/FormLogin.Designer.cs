namespace ViewAuthorization
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonPassChar = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonFogot = new System.Windows.Forms.Button();
            this.panelCap = new System.Windows.Forms.Panel();
            this.labelSkip = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.panelCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelMain.Controls.Add(this.buttonPassChar);
            this.panelMain.Controls.Add(this.textBoxPass);
            this.panelMain.Controls.Add(this.buttonFogot);
            this.panelMain.Controls.Add(this.panelCap);
            this.panelMain.Controls.Add(this.pictureBoxLogo);
            this.panelMain.Controls.Add(this.buttonSignIn);
            this.panelMain.Controls.Add(this.buttonRegister);
            this.panelMain.Controls.Add(this.panelLine2);
            this.panelMain.Controls.Add(this.pictureBoxPass);
            this.panelMain.Controls.Add(this.panelLine1);
            this.panelMain.Controls.Add(this.pictureBoxLogin);
            this.panelMain.Controls.Add(this.textBoxLogin);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(424, 550);
            this.panelMain.TabIndex = 0;
            // 
            // buttonPassChar
            // 
            this.buttonPassChar.BackgroundImage = global::ViewAuthorization.Properties.Resources.eye;
            this.buttonPassChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPassChar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPassChar.FlatAppearance.BorderSize = 0;
            this.buttonPassChar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPassChar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonPassChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPassChar.Location = new System.Drawing.Point(320, 294);
            this.buttonPassChar.Name = "buttonPassChar";
            this.buttonPassChar.Size = new System.Drawing.Size(28, 28);
            this.buttonPassChar.TabIndex = 1017;
            this.buttonPassChar.UseVisualStyleBackColor = false;
            this.buttonPassChar.Click += new System.EventHandler(this.buttonPassChar_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPass.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.ForeColor = System.Drawing.Color.White;
            this.textBoxPass.Location = new System.Drawing.Point(133, 303);
            this.textBoxPass.MaxLength = 30;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(219, 21);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.WordWrap = false;
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // buttonFogot
            // 
            this.buttonFogot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonFogot.FlatAppearance.BorderSize = 0;
            this.buttonFogot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonFogot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonFogot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFogot.Font = new System.Drawing.Font("Arial", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFogot.ForeColor = System.Drawing.Color.White;
            this.buttonFogot.Location = new System.Drawing.Point(80, 333);
            this.buttonFogot.Name = "buttonFogot";
            this.buttonFogot.Size = new System.Drawing.Size(270, 24);
            this.buttonFogot.TabIndex = 0;
            this.buttonFogot.Text = "Forgot password?";
            this.buttonFogot.UseVisualStyleBackColor = true;
            this.buttonFogot.Click += new System.EventHandler(this.buttonFogot_Click);
            // 
            // panelCap
            // 
            this.panelCap.Controls.Add(this.labelSkip);
            this.panelCap.Controls.Add(this.labelExit);
            this.panelCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCap.Location = new System.Drawing.Point(0, 0);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(424, 32);
            this.panelCap.TabIndex = 0;
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
            this.labelSkip.Click += new System.EventHandler(this.label1_Click);
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
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(148, 38);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Arial", 14.86792F);
            this.buttonSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonSignIn.Location = new System.Drawing.Point(79, 373);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(270, 48);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Arial", 14.86792F);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(79, 440);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(270, 48);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Sign Up";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // panelLine2
            // 
            this.panelLine2.BackColor = System.Drawing.Color.White;
            this.panelLine2.Location = new System.Drawing.Point(80, 330);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(270, 1);
            this.panelLine2.TabIndex = 0;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = global::ViewAuthorization.Properties.Resources.pass;
            this.pictureBoxPass.Location = new System.Drawing.Point(80, 276);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPass.TabIndex = 4;
            this.pictureBoxPass.TabStop = false;
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.White;
            this.panelLine1.Location = new System.Drawing.Point(80, 249);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(270, 1);
            this.panelLine1.TabIndex = 1;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::ViewAuthorization.Properties.Resources.log;
            this.pictureBoxLogin.Location = new System.Drawing.Point(80, 199);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxLogin.Location = new System.Drawing.Point(131, 221);
            this.textBoxLogin.MaxLength = 25;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(219, 21);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.Text = "Login";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 550);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Button buttonFogot;
        private System.Windows.Forms.Label labelSkip;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonPassChar;
    }
}