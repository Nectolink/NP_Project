namespace Project_NP_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SignIn = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.tb_pass = new MetroFramework.Controls.MetroTextBox();
            this.tb_email = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "LOGIN";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Highlight = true;
            this.btn_SignIn.Location = new System.Drawing.Point(22, 319);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(126, 25);
            this.btn_SignIn.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_SignIn.TabIndex = 12;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseSelectable = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Highlight = true;
            this.btn_exit.Location = new System.Drawing.Point(155, 319);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(122, 25);
            this.btn_exit.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_pass
            // 
            // 
            // 
            // 
            this.tb_pass.CustomButton.Image = null;
            this.tb_pass.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.tb_pass.CustomButton.Name = "";
            this.tb_pass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pass.CustomButton.TabIndex = 1;
            this.tb_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pass.CustomButton.UseSelectable = true;
            this.tb_pass.CustomButton.Visible = false;
            this.tb_pass.Lines = new string[] {
        "Enter your password"};
            this.tb_pass.Location = new System.Drawing.Point(22, 283);
            this.tb_pass.MaxLength = 32767;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '\0';
            this.tb_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pass.SelectedText = "";
            this.tb_pass.SelectionLength = 0;
            this.tb_pass.SelectionStart = 0;
            this.tb_pass.Size = new System.Drawing.Size(255, 25);
            this.tb_pass.TabIndex = 7;
            this.tb_pass.Text = "Enter your password";
            this.tb_pass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pass.UseSelectable = true;
            this.tb_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tb_email.CustomButton.Image = null;
            this.tb_email.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.tb_email.CustomButton.Name = "";
            this.tb_email.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tb_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_email.CustomButton.TabIndex = 1;
            this.tb_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_email.CustomButton.UseSelectable = true;
            this.tb_email.CustomButton.Visible = false;
            this.tb_email.Lines = new string[] {
        "example@example.com"};
            this.tb_email.Location = new System.Drawing.Point(22, 234);
            this.tb_email.MaxLength = 32767;
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordChar = '\0';
            this.tb_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_email.SelectedText = "";
            this.tb_email.SelectionLength = 0;
            this.tb_email.SelectionStart = 0;
            this.tb_email.Size = new System.Drawing.Size(255, 25);
            this.tb_email.TabIndex = 8;
            this.tb_email.Text = "example@example.com";
            this.tb_email.UseSelectable = true;
            this.tb_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Don\'t have an account?";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Location = new System.Drawing.Point(171, 363);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(100, 14);
            this.lblCreateAccount.TabIndex = 22;
            this.lblCreateAccount.TabStop = true;
            this.lblCreateAccount.Text = "Create Account";
            this.lblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreateAccount_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(307, 397);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_email);
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btn_SignIn;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroTextBox tb_pass;
        private MetroFramework.Controls.MetroTextBox tb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblCreateAccount;
    }
}

