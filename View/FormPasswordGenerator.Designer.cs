namespace View
{
    partial class FormPasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCap = new System.Windows.Forms.Panel();
            this.labelSkip = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelCurrentValue = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.specialBox = new System.Windows.Forms.CheckBox();
            this.numericBox = new System.Windows.Forms.CheckBox();
            this.lowercaseBox = new System.Windows.Forms.CheckBox();
            this.uppercaseBox = new System.Windows.Forms.CheckBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            this.panelCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.panelCap);
            this.panelMain.Controls.Add(this.labelCurrentValue);
            this.panelMain.Controls.Add(this.trackBar1);
            this.panelMain.Controls.Add(this.buttonGenerate);
            this.panelMain.Controls.Add(this.specialBox);
            this.panelMain.Controls.Add(this.numericBox);
            this.panelMain.Controls.Add(this.lowercaseBox);
            this.panelMain.Controls.Add(this.uppercaseBox);
            this.panelMain.Controls.Add(this.textBoxPass);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(398, 241);
            this.panelMain.TabIndex = 0;
            // 
            // panelCap
            // 
            this.panelCap.Controls.Add(this.labelSkip);
            this.panelCap.Controls.Add(this.labelExit);
            this.panelCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCap.ForeColor = System.Drawing.Color.White;
            this.panelCap.Location = new System.Drawing.Point(-27, -2);
            this.panelCap.Name = "panelCap";
            this.panelCap.Size = new System.Drawing.Size(430, 35);
            this.panelCap.TabIndex = 1019;
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
            this.labelExit.Image = global::View.Properties.Resources.close;
            this.labelExit.Location = new System.Drawing.Point(395, 4);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(25, 20);
            this.labelExit.TabIndex = 8;
            this.labelExit.Text = "    ";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelCurrentValue
            // 
            this.labelCurrentValue.AutoSize = true;
            this.labelCurrentValue.Font = new System.Drawing.Font("Arial", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentValue.ForeColor = System.Drawing.Color.White;
            this.labelCurrentValue.Location = new System.Drawing.Point(123, 114);
            this.labelCurrentValue.Name = "labelCurrentValue";
            this.labelCurrentValue.Size = new System.Drawing.Size(131, 18);
            this.labelCurrentValue.TabIndex = 1018;
            this.labelCurrentValue.Text = "labelCurrentValue";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(42, 82);
            this.trackBar1.Maximum = 26;
            this.trackBar1.Minimum = 8;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(308, 50);
            this.trackBar1.TabIndex = 1017;
            this.trackBar1.Value = 17;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(177)))), ((int)(((byte)(146)))));
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Arial", 14.9434F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonGenerate.Location = new System.Drawing.Point(42, 185);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(308, 45);
            this.buttonGenerate.TabIndex = 1015;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // specialBox
            // 
            this.specialBox.AutoSize = true;
            this.specialBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.specialBox.Font = new System.Drawing.Font("Arial", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialBox.ForeColor = System.Drawing.Color.White;
            this.specialBox.Location = new System.Drawing.Point(236, 150);
            this.specialBox.Name = "specialBox";
            this.specialBox.Size = new System.Drawing.Size(127, 20);
            this.specialBox.TabIndex = 1014;
            this.specialBox.Text = "Special symbols";
            this.specialBox.UseVisualStyleBackColor = true;
            // 
            // numericBox
            // 
            this.numericBox.AutoSize = true;
            this.numericBox.Checked = true;
            this.numericBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numericBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.numericBox.Font = new System.Drawing.Font("Arial", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericBox.ForeColor = System.Drawing.Color.White;
            this.numericBox.Location = new System.Drawing.Point(174, 150);
            this.numericBox.Name = "numericBox";
            this.numericBox.Size = new System.Drawing.Size(47, 20);
            this.numericBox.TabIndex = 1013;
            this.numericBox.Text = "0-9";
            this.numericBox.UseVisualStyleBackColor = true;
            // 
            // lowercaseBox
            // 
            this.lowercaseBox.AutoCheck = false;
            this.lowercaseBox.AutoSize = true;
            this.lowercaseBox.Checked = true;
            this.lowercaseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercaseBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lowercaseBox.Font = new System.Drawing.Font("Arial", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowercaseBox.ForeColor = System.Drawing.Color.White;
            this.lowercaseBox.Location = new System.Drawing.Point(109, 150);
            this.lowercaseBox.Name = "lowercaseBox";
            this.lowercaseBox.Size = new System.Drawing.Size(45, 20);
            this.lowercaseBox.TabIndex = 1012;
            this.lowercaseBox.Text = "a-z";
            this.lowercaseBox.UseVisualStyleBackColor = true;
            // 
            // uppercaseBox
            // 
            this.uppercaseBox.AutoSize = true;
            this.uppercaseBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uppercaseBox.Font = new System.Drawing.Font("Arial", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uppercaseBox.ForeColor = System.Drawing.Color.White;
            this.uppercaseBox.Location = new System.Drawing.Point(42, 150);
            this.uppercaseBox.Name = "uppercaseBox";
            this.uppercaseBox.Size = new System.Drawing.Size(48, 20);
            this.uppercaseBox.TabIndex = 1011;
            this.uppercaseBox.Text = "A-Z";
            this.uppercaseBox.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxPass.Font = new System.Drawing.Font("Arial", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.ForeColor = System.Drawing.Color.White;
            this.textBoxPass.Location = new System.Drawing.Point(39, 33);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(311, 34);
            this.textBoxPass.TabIndex = 1016;
            this.textBoxPass.Text = "password";
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            // 
            // FormPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(398, 241);
            this.Controls.Add(this.panelMain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPasswordGenerator";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPasswordGenerator";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCap.ResumeLayout(false);
            this.panelCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCap;
        private System.Windows.Forms.Label labelSkip;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelCurrentValue;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.CheckBox specialBox;
        private System.Windows.Forms.CheckBox numericBox;
        private System.Windows.Forms.CheckBox lowercaseBox;
        private System.Windows.Forms.CheckBox uppercaseBox;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}