namespace Project_NP_
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SignIn = new MetroFramework.Controls.MetroButton();
            this.btn_Create = new MetroFramework.Controls.MetroButton();
            this.tb_pass = new MetroFramework.Controls.MetroTextBox();
            this.tb_userName = new MetroFramework.Controls.MetroTextBox();
            this.tb_email = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Highlight = true;
            this.btn_SignIn.Location = new System.Drawing.Point(369, 213);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(108, 23);
            this.btn_SignIn.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_SignIn.TabIndex = 15;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseSelectable = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Highlight = true;
            this.btn_Create.Location = new System.Drawing.Point(258, 213);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(105, 23);
            this.btn_Create.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_Create.TabIndex = 16;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseSelectable = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // tb_pass
            // 
            // 
            // 
            // 
            this.tb_pass.CustomButton.Image = null;
            this.tb_pass.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.tb_pass.CustomButton.Name = "";
            this.tb_pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pass.CustomButton.TabIndex = 1;
            this.tb_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pass.CustomButton.UseSelectable = true;
            this.tb_pass.CustomButton.Visible = false;
            this.tb_pass.Lines = new string[] {
        "Enter your password"};
            this.tb_pass.Location = new System.Drawing.Point(258, 164);
            this.tb_pass.MaxLength = 32767;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '\0';
            this.tb_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pass.SelectedText = "";
            this.tb_pass.SelectionLength = 0;
            this.tb_pass.SelectionStart = 0;
            this.tb_pass.Size = new System.Drawing.Size(219, 23);
            this.tb_pass.TabIndex = 9;
            this.tb_pass.Text = "Enter your password";
            this.tb_pass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pass.UseSelectable = true;
            this.tb_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_userName
            // 
            this.tb_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tb_userName.CustomButton.Image = null;
            this.tb_userName.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.tb_userName.CustomButton.Name = "";
            this.tb_userName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_userName.CustomButton.TabIndex = 1;
            this.tb_userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_userName.CustomButton.UseSelectable = true;
            this.tb_userName.CustomButton.Visible = false;
            this.tb_userName.Lines = new string[] {
        "example@example.com"};
            this.tb_userName.Location = new System.Drawing.Point(258, 78);
            this.tb_userName.MaxLength = 32767;
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.PasswordChar = '\0';
            this.tb_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_userName.SelectedText = "";
            this.tb_userName.SelectionLength = 0;
            this.tb_userName.SelectionStart = 0;
            this.tb_userName.Size = new System.Drawing.Size(219, 23);
            this.tb_userName.TabIndex = 10;
            this.tb_userName.Text = "example@example.com";
            this.tb_userName.UseSelectable = true;
            this.tb_userName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_userName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.tb_email.CustomButton.Image = null;
            this.tb_email.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.tb_email.CustomButton.Name = "";
            this.tb_email.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_email.CustomButton.TabIndex = 1;
            this.tb_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_email.CustomButton.UseSelectable = true;
            this.tb_email.CustomButton.Visible = false;
            this.tb_email.Lines = new string[] {
        "example@example.com"};
            this.tb_email.Location = new System.Drawing.Point(258, 124);
            this.tb_email.MaxLength = 32767;
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordChar = '\0';
            this.tb_email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_email.SelectedText = "";
            this.tb_email.SelectionLength = 0;
            this.tb_email.SelectionStart = 0;
            this.tb_email.Size = new System.Drawing.Size(219, 23);
            this.tb_email.TabIndex = 11;
            this.tb_email.Text = "example@example.com";
            this.tb_email.UseSelectable = true;
            this.tb_email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(168, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(198, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(198, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(132, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 40);
            this.label4.TabIndex = 24;
            this.label4.Text = "registration";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.tb_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btn_SignIn;
        private MetroFramework.Controls.MetroButton btn_Create;
        private MetroFramework.Controls.MetroTextBox tb_pass;
        private MetroFramework.Controls.MetroTextBox tb_userName;
        private MetroFramework.Controls.MetroTextBox tb_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;

    }
}