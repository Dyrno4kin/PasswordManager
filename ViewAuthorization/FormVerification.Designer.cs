namespace ViewAuthorization
{
    partial class FormVerification
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
            this.buttonUpdateCode = new System.Windows.Forms.Button();
            this.panelCap = new System.Windows.Forms.Panel();
            this.labelSkip = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.pictureBoxCode = new System.Windows.Forms.PictureBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonUpdateCode);
            this.panel1.Controls.Add(this.panelCap);
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Controls.Add(this.panelLine1);
            this.panel1.Controls.Add(this.pictureBoxCode);
            this.panel1.Controls.Add(this.textBoxCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 220);
            this.panel1.TabIndex = 0;
            // 
            // buttonUpdateCode
            // 
            this.buttonUpdateCode.BackgroundImage = global::ViewAuthorization.Properties.Resources.update;
            this.buttonUpdateCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdateCode.FlatAppearance.BorderSize = 0;
            this.buttonUpdateCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateCode.Image = global::ViewAuthorization.Properties.Resources.update;
            this.buttonUpdateCode.Location = new System.Drawing.Point(283, 77);
            this.buttonUpdateCode.Name = "buttonUpdateCode";
            this.buttonUpdateCode.Size = new System.Drawing.Size(34, 34);
            this.buttonUpdateCode.TabIndex = 23;
            this.buttonUpdateCode.UseVisualStyleBackColor = false;
            this.buttonUpdateCode.Click += new System.EventHandler(this.buttonUpdateCode_Click);
            // 
            // panelCap
            // 
            this.panelCap.Controls.Add(this.labelSkip);
            this.panelCap.Controls.Add(this.labelExit);
            this.panelCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCap.Location = new System.Drawing.Point(-59, 3);
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
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Arial", 14.86792F);
            this.buttonOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonOk.Location = new System.Drawing.Point(46, 140);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(271, 48);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.Color.White;
            this.panelLine1.Location = new System.Drawing.Point(47, 114);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(270, 1);
            this.panelLine1.TabIndex = 14;
            // 
            // pictureBoxCode
            // 
            this.pictureBoxCode.Image = global::ViewAuthorization.Properties.Resources.key;
            this.pictureBoxCode.Location = new System.Drawing.Point(47, 61);
            this.pictureBoxCode.Name = "pictureBoxCode";
            this.pictureBoxCode.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCode.TabIndex = 15;
            this.pictureBoxCode.TabStop = false;
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxCode.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCode.ForeColor = System.Drawing.Color.White;
            this.textBoxCode.Location = new System.Drawing.Point(98, 86);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(219, 21);
            this.textBoxCode.TabIndex = 2;
            this.textBoxCode.Text = "Enter code from email";
            this.textBoxCode.Enter += new System.EventHandler(this.textBoxCode_Enter);
            this.textBoxCode.Leave += new System.EventHandler(this.textBoxCode_Leave);
            // 
            // FormVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 220);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerification";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFogotPassword";
            this.Load += new System.EventHandler(this.FormVerification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.PictureBox pictureBoxCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Label labelSkip;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Button buttonUpdateCode;
    }
}