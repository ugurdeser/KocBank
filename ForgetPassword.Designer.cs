namespace KocBank
{
    partial class ForgetPassword
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
            label1 = new Label();
            txt_GovermentID = new TextBox();
            lbl_MailKey = new TextBox();
            label2 = new Label();
            btn_NewPassword = new Button();
            label3 = new Label();
            lbl_PhoneKey = new TextBox();
            btn_Send = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(30, 58);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No :";
            // 
            // txt_GovermentID
            // 
            txt_GovermentID.Location = new Point(137, 55);
            txt_GovermentID.Name = "txt_GovermentID";
            txt_GovermentID.Size = new Size(344, 23);
            txt_GovermentID.TabIndex = 1;
            // 
            // lbl_MailKey
            // 
            lbl_MailKey.Location = new Point(137, 122);
            lbl_MailKey.Name = "lbl_MailKey";
            lbl_MailKey.Size = new Size(344, 23);
            lbl_MailKey.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Location = new Point(20, 125);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Maile Gelen Sifre :";
            // 
            // btn_NewPassword
            // 
            btn_NewPassword.FlatStyle = FlatStyle.System;
            btn_NewPassword.Location = new Point(234, 203);
            btn_NewPassword.Name = "btn_NewPassword";
            btn_NewPassword.Size = new Size(136, 23);
            btn_NewPassword.TabIndex = 4;
            btn_NewPassword.Text = "Gönder";
            btn_NewPassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefona Gelen Sifre :";
            // 
            // lbl_PhoneKey
            // 
            lbl_PhoneKey.Location = new Point(137, 162);
            lbl_PhoneKey.Name = "lbl_PhoneKey";
            lbl_PhoneKey.Size = new Size(344, 23);
            lbl_PhoneKey.TabIndex = 5;
            // 
            // btn_Send
            // 
            btn_Send.FlatStyle = FlatStyle.System;
            btn_Send.Location = new Point(234, 89);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(136, 23);
            btn_Send.TabIndex = 7;
            btn_Send.Text = "Şifre Gönder";
            btn_Send.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(172, 15);
            label4.Name = "label4";
            label4.Size = new Size(274, 25);
            label4.TabIndex = 8;
            label4.Text = "KOCBANK ŞİFRE YENİLEME";
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 236);
            Controls.Add(label4);
            Controls.Add(btn_Send);
            Controls.Add(label3);
            Controls.Add(lbl_PhoneKey);
            Controls.Add(btn_NewPassword);
            Controls.Add(label2);
            Controls.Add(lbl_MailKey);
            Controls.Add(txt_GovermentID);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            Load += ForgetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_GovermentID;
        private TextBox lbl_MailKey;
        private Label label2;
        private Button btn_NewPassword;
        private Label label3;
        private TextBox lbl_PhoneKey;
        private Button btn_Send;
        private Label label4;
    }
}