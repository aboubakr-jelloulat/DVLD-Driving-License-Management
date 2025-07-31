namespace Presentation.Login
{
    partial class frmLogin
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorInfoValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbDrivingLiecenceImage = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chckRememberMe = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnSubmet = new System.Windows.Forms.Button();
            this.txtboxLoginPassword = new System.Windows.Forms.TextBox();
            this.txtboxLoginUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorInfoValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivingLiecenceImage)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(69, 131);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(672, 49);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Driving License Management";
            this.lblTitle.Click += new System.EventHandler(this.label4_Click);
            // 
            // errorInfoValidation
            // 
            this.errorInfoValidation.ContainerControl = this;
            // 
            // pbDrivingLiecenceImage
            // 
            this.pbDrivingLiecenceImage.Image = global::Presentation.Properties.Resources.Screenshot_2025_07_27_154353;
            this.pbDrivingLiecenceImage.Location = new System.Drawing.Point(863, 65);
            this.pbDrivingLiecenceImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbDrivingLiecenceImage.Name = "pbDrivingLiecenceImage";
            this.pbDrivingLiecenceImage.Size = new System.Drawing.Size(961, 966);
            this.pbDrivingLiecenceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDrivingLiecenceImage.TabIndex = 8;
            this.pbDrivingLiecenceImage.TabStop = false;
            this.pbDrivingLiecenceImage.Click += new System.EventHandler(this.pbDrivingLiecenceImage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(205, 442);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Remember Me.";
            // 
            // chckRememberMe
            // 
            this.chckRememberMe.AutoSize = true;
            this.chckRememberMe.Checked = true;
            this.chckRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckRememberMe.Location = new System.Drawing.Point(179, 447);
            this.chckRememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.chckRememberMe.Name = "chckRememberMe";
            this.chckRememberMe.Size = new System.Drawing.Size(18, 17);
            this.chckRememberMe.TabIndex = 31;
            this.chckRememberMe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(43, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(43, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(196, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Welcom Back! Please Enter Your Details\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(279, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 50);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sign In";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1837, 57);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.btnSubmet);
            this.pnlLogin.Controls.Add(this.txtboxLoginPassword);
            this.pnlLogin.Controls.Add(this.txtboxLoginUsername);
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Controls.Add(this.chckRememberMe);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(56, 289);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(712, 623);
            this.pnlLogin.TabIndex = 9;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // btnSubmet
            // 
            this.btnSubmet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubmet.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmet.Location = new System.Drawing.Point(257, 509);
            this.btnSubmet.Name = "btnSubmet";
            this.btnSubmet.Size = new System.Drawing.Size(184, 40);
            this.btnSubmet.TabIndex = 3;
            this.btnSubmet.Text = "Submit";
            this.btnSubmet.UseVisualStyleBackColor = false;
            this.btnSubmet.Click += new System.EventHandler(this.btnSubmet_Click);
            // 
            // txtboxLoginPassword
            // 
            this.txtboxLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxLoginPassword.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLoginPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtboxLoginPassword.Location = new System.Drawing.Point(179, 366);
            this.txtboxLoginPassword.Multiline = true;
            this.txtboxLoginPassword.Name = "txtboxLoginPassword";
            this.txtboxLoginPassword.PasswordChar = '*';
            this.txtboxLoginPassword.Size = new System.Drawing.Size(407, 50);
            this.txtboxLoginPassword.TabIndex = 2;
            // 
            // txtboxLoginUsername
            // 
            this.txtboxLoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtboxLoginUsername.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLoginUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtboxLoginUsername.Location = new System.Drawing.Point(179, 235);
            this.txtboxLoginUsername.Multiline = true;
            this.txtboxLoginUsername.Name = "txtboxLoginUsername";
            this.txtboxLoginUsername.Size = new System.Drawing.Size(407, 47);
            this.txtboxLoginUsername.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 1055);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbDrivingLiecenceImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.errorInfoValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivingLiecenceImage)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorInfoValidation;
        private System.Windows.Forms.PictureBox pbDrivingLiecenceImage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chckRememberMe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxLoginUsername;
        private System.Windows.Forms.TextBox txtboxLoginPassword;
        private System.Windows.Forms.Button btnSubmet;
    }
}