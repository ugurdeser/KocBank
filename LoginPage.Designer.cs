namespace KocBank
{
    partial class LoginPage
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
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_ForgetPassword = new LinkLabel();
            btn_Login = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(93, 81);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(172, 23);
            txt_UserName.TabIndex = 0;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(93, 121);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(172, 23);
            txt_Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 84);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 124);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            // 
            // lbl_ForgetPassword
            // 
            lbl_ForgetPassword.AutoSize = true;
            lbl_ForgetPassword.Location = new Point(170, 204);
            lbl_ForgetPassword.Name = "lbl_ForgetPassword";
            lbl_ForgetPassword.Size = new Size(95, 15);
            lbl_ForgetPassword.TabIndex = 4;
            lbl_ForgetPassword.TabStop = true;
            lbl_ForgetPassword.Text = "Şifremi Unuttum";
            lbl_ForgetPassword.LinkClicked += lbl_ForgetPassword_LinkClicked;
            // 
            // btn_Login
            // 
            btn_Login.FlatStyle = FlatStyle.System;
            btn_Login.Location = new Point(152, 163);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(113, 23);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 35);
            label3.Name = "label3";
            label3.Size = new Size(189, 25);
            label3.TabIndex = 6;
            label3.Text = "KOCBANK LOGIN";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 260);
            Controls.Add(label3);
            Controls.Add(btn_Login);
            Controls.Add(lbl_ForgetPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Label label1;
        private Label label2;
        private LinkLabel lbl_ForgetPassword;
        private Button btn_Login;
        private Label label3;
    }
}