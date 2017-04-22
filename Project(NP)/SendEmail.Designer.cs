namespace Project_NP_
{
    partial class SendEmail
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
            this.tb_To = new System.Windows.Forms.TextBox();
            this.tb_subj = new System.Windows.Forms.TextBox();
            this.tb_attach = new System.Windows.Forms.TextBox();
            this.btn_send = new MetroFramework.Controls.MetroButton();
            this.Browse = new MetroFramework.Controls.MetroButton();
            this.tb_body = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.browsAttach = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tb_To
            // 
            this.tb_To.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_To.Location = new System.Drawing.Point(95, 56);
            this.tb_To.Multiline = true;
            this.tb_To.Name = "tb_To";
            this.tb_To.Size = new System.Drawing.Size(474, 23);
            this.tb_To.TabIndex = 19;
            // 
            // tb_subj
            // 
            this.tb_subj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_subj.Location = new System.Drawing.Point(95, 85);
            this.tb_subj.Multiline = true;
            this.tb_subj.Name = "tb_subj";
            this.tb_subj.Size = new System.Drawing.Size(474, 23);
            this.tb_subj.TabIndex = 18;
            // 
            // tb_attach
            // 
            this.tb_attach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_attach.Location = new System.Drawing.Point(97, 370);
            this.tb_attach.Multiline = true;
            this.tb_attach.Name = "tb_attach";
            this.tb_attach.Size = new System.Drawing.Size(357, 23);
            this.tb_attach.TabIndex = 17;
            // 
            // btn_send
            // 
            this.btn_send.Highlight = true;
            this.btn_send.Location = new System.Drawing.Point(97, 399);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(357, 23);
            this.btn_send.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_send.TabIndex = 16;
            this.btn_send.Text = "Send";
            this.btn_send.UseSelectable = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Browse
            // 
            this.Browse.Highlight = true;
            this.Browse.Location = new System.Drawing.Point(460, 370);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(109, 23);
            this.Browse.Style = MetroFramework.MetroColorStyle.Silver;
            this.Browse.TabIndex = 15;
            this.Browse.Text = "Browse";
            this.Browse.UseSelectable = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // tb_body
            // 
            this.tb_body.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_body.Location = new System.Drawing.Point(95, 114);
            this.tb_body.Multiline = true;
            this.tb_body.Name = "tb_body";
            this.tb_body.Size = new System.Drawing.Size(474, 250);
            this.tb_body.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(244, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 40);
            this.label4.TabIndex = 25;
            this.label4.Text = "Compose";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(5, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "attach";
            // 
            // btnBack
            // 
            this.btnBack.Highlight = true;
            this.btnBack.Location = new System.Drawing.Point(460, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 23);
            this.btnBack.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // browsAttach
            // 
            this.browsAttach.FileName = "brows";
            this.browsAttach.FileOk += new System.ComponentModel.CancelEventHandler(this.browsAttach_FileOk);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 434);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_To);
            this.Controls.Add(this.tb_subj);
            this.Controls.Add(this.tb_attach);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.tb_body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_To;
        private System.Windows.Forms.TextBox tb_subj;
        private System.Windows.Forms.TextBox tb_attach;
        private MetroFramework.Controls.MetroButton btn_send;
        private MetroFramework.Controls.MetroButton Browse;
        private System.Windows.Forms.TextBox tb_body;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.OpenFileDialog browsAttach;
    }
}