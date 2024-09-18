namespace KocBank
{
    partial class CheckingAccount
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
            groupBox3 = new GroupBox();
            txt_Da_CommissionRate = new TextBox();
            label11 = new Label();
            btn_Da_Add = new Button();
            cbx_Currency = new ComboBox();
            txt_Da_InterestRate = new TextBox();
            label10 = new Label();
            label7 = new Label();
            lvl_Da_Title = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            txt_SearchGovermentID = new TextBox();
            btn_Da_Take = new Button();
            groupBox4 = new GroupBox();
            btn_Print = new Button();
            lbl_IBAN = new Label();
            label14 = new Label();
            lbl_AccountNumber = new Label();
            label12 = new Label();
            printDoc = new System.Drawing.Printing.PrintDocument();
            dgv_AllAccounts = new DataGridView();
            groupBox1 = new GroupBox();
            lbl_Da_Name = new Label();
            lbl_Da_LastName = new Label();
            lbl_Da_GovernmentID = new Label();
            lbl_Da_Phone = new Label();
            lbl_Da_BirthDate = new Label();
            lbl_Da_Address = new Label();
            lbl_Da_Email = new Label();
            lbl_Da_City = new Label();
            lbl_Ad = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pb_Da_Customer = new PictureBox();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AllAccounts).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Da_Customer).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_Da_CommissionRate);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(btn_Da_Add);
            groupBox3.Controls.Add(cbx_Currency);
            groupBox3.Controls.Add(txt_Da_InterestRate);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(375, 166);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(771, 149);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Doldurulacak Bilgıler";
            // 
            // txt_Da_CommissionRate
            // 
            txt_Da_CommissionRate.Location = new Point(606, 45);
            txt_Da_CommissionRate.Name = "txt_Da_CommissionRate";
            txt_Da_CommissionRate.Size = new Size(140, 23);
            txt_Da_CommissionRate.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(508, 50);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 5;
            label11.Text = "Komisyon Oranı";
            // 
            // btn_Da_Add
            // 
            btn_Da_Add.Location = new Point(269, 94);
            btn_Da_Add.Name = "btn_Da_Add";
            btn_Da_Add.Size = new Size(183, 23);
            btn_Da_Add.TabIndex = 4;
            btn_Da_Add.Text = "Hesap Aç";
            btn_Da_Add.UseVisualStyleBackColor = true;
            // 
            // cbx_Currency
            // 
            cbx_Currency.FormattingEnabled = true;
            cbx_Currency.Location = new Point(126, 45);
            cbx_Currency.Name = "cbx_Currency";
            cbx_Currency.Size = new Size(140, 23);
            cbx_Currency.TabIndex = 3;
            // 
            // txt_Da_InterestRate
            // 
            txt_Da_InterestRate.Location = new Point(355, 45);
            txt_Da_InterestRate.Name = "txt_Da_InterestRate";
            txt_Da_InterestRate.Size = new Size(140, 23);
            txt_Da_InterestRate.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(282, 49);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 1;
            label10.Text = "Faiz Oranı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 49);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 0;
            label7.Text = "Hesap Para Cinsi";
            // 
            // lvl_Da_Title
            // 
            lvl_Da_Title.AutoSize = true;
            lvl_Da_Title.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lvl_Da_Title.Location = new Point(375, 80);
            lvl_Da_Title.Name = "lvl_Da_Title";
            lvl_Da_Title.Size = new Size(398, 32);
            lvl_Da_Title.TabIndex = 33;
            lvl_Da_Title.Text = "KOÇBANK VADESİZ HESAP AÇILIŞ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_SearchGovermentID);
            groupBox2.Controls.Add(btn_Da_Take);
            groupBox2.Location = new Point(12, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 149);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Getir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(132, 34);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 22;
            label9.Text = "TC Kimlik No";
            // 
            // txt_SearchGovermentID
            // 
            txt_SearchGovermentID.Location = new Point(36, 60);
            txt_SearchGovermentID.Name = "txt_SearchGovermentID";
            txt_SearchGovermentID.Size = new Size(267, 23);
            txt_SearchGovermentID.TabIndex = 23;
            // 
            // btn_Da_Take
            // 
            btn_Da_Take.Location = new Point(106, 94);
            btn_Da_Take.Name = "btn_Da_Take";
            btn_Da_Take.Size = new Size(126, 23);
            btn_Da_Take.TabIndex = 22;
            btn_Da_Take.Text = "Getir";
            btn_Da_Take.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_Print);
            groupBox4.Controls.Add(lbl_IBAN);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(lbl_AccountNumber);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(551, 517);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(418, 155);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hesap Bilgileri";
            // 
            // btn_Print
            // 
            btn_Print.Location = new Point(93, 116);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(183, 23);
            btn_Print.TabIndex = 4;
            btn_Print.Text = "Yazdır";
            btn_Print.UseVisualStyleBackColor = true;
            // 
            // lbl_IBAN
            // 
            lbl_IBAN.AutoSize = true;
            lbl_IBAN.Location = new Point(199, 75);
            lbl_IBAN.Name = "lbl_IBAN";
            lbl_IBAN.Size = new Size(34, 15);
            lbl_IBAN.TabIndex = 3;
            lbl_IBAN.Text = "IBAN";
            lbl_IBAN.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(93, 75);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 2;
            label14.Text = "IBAN :";
            // 
            // lbl_AccountNumber
            // 
            lbl_AccountNumber.AutoSize = true;
            lbl_AccountNumber.Location = new Point(199, 38);
            lbl_AccountNumber.Name = "lbl_AccountNumber";
            lbl_AccountNumber.Size = new Size(94, 15);
            lbl_AccountNumber.TabIndex = 1;
            lbl_AccountNumber.Text = "Hesap Numarası";
            lbl_AccountNumber.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(93, 38);
            label12.Name = "label12";
            label12.Size = new Size(100, 15);
            label12.TabIndex = 0;
            label12.Text = "Hesap Numarası :";
            // 
            // dgv_AllAccounts
            // 
            dgv_AllAccounts.AllowUserToAddRows = false;
            dgv_AllAccounts.AllowUserToDeleteRows = false;
            dgv_AllAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AllAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AllAccounts.Location = new Point(375, 340);
            dgv_AllAccounts.Name = "dgv_AllAccounts";
            dgv_AllAccounts.Size = new Size(771, 171);
            dgv_AllAccounts.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_Da_Name);
            groupBox1.Controls.Add(lbl_Da_LastName);
            groupBox1.Controls.Add(lbl_Da_GovernmentID);
            groupBox1.Controls.Add(lbl_Da_Phone);
            groupBox1.Controls.Add(lbl_Da_BirthDate);
            groupBox1.Controls.Add(lbl_Da_Address);
            groupBox1.Controls.Add(lbl_Da_Email);
            groupBox1.Controls.Add(lbl_Da_City);
            groupBox1.Controls.Add(lbl_Ad);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pb_Da_Customer);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 340);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 335);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap Açılacak Müşteri";
            // 
            // lbl_Da_Name
            // 
            lbl_Da_Name.AutoSize = true;
            lbl_Da_Name.Location = new Point(127, 29);
            lbl_Da_Name.Name = "lbl_Da_Name";
            lbl_Da_Name.Size = new Size(22, 15);
            lbl_Da_Name.TabIndex = 19;
            lbl_Da_Name.Text = "Ad";
            lbl_Da_Name.Visible = false;
            // 
            // lbl_Da_LastName
            // 
            lbl_Da_LastName.AutoSize = true;
            lbl_Da_LastName.Location = new Point(127, 66);
            lbl_Da_LastName.Name = "lbl_Da_LastName";
            lbl_Da_LastName.Size = new Size(39, 15);
            lbl_Da_LastName.TabIndex = 20;
            lbl_Da_LastName.Text = "Soyad";
            lbl_Da_LastName.Visible = false;
            // 
            // lbl_Da_GovernmentID
            // 
            lbl_Da_GovernmentID.AutoSize = true;
            lbl_Da_GovernmentID.Location = new Point(127, 140);
            lbl_Da_GovernmentID.Name = "lbl_Da_GovernmentID";
            lbl_Da_GovernmentID.Size = new Size(75, 15);
            lbl_Da_GovernmentID.TabIndex = 21;
            lbl_Da_GovernmentID.Text = "TC Kimlik No";
            lbl_Da_GovernmentID.Visible = false;
            // 
            // lbl_Da_Phone
            // 
            lbl_Da_Phone.AutoSize = true;
            lbl_Da_Phone.Location = new Point(127, 177);
            lbl_Da_Phone.Name = "lbl_Da_Phone";
            lbl_Da_Phone.Size = new Size(64, 15);
            lbl_Da_Phone.TabIndex = 22;
            lbl_Da_Phone.Text = "Telefon No";
            lbl_Da_Phone.Visible = false;
            // 
            // lbl_Da_BirthDate
            // 
            lbl_Da_BirthDate.AutoSize = true;
            lbl_Da_BirthDate.Location = new Point(127, 103);
            lbl_Da_BirthDate.Name = "lbl_Da_BirthDate";
            lbl_Da_BirthDate.Size = new Size(78, 15);
            lbl_Da_BirthDate.TabIndex = 27;
            lbl_Da_BirthDate.Text = "Doğum Tarihi";
            lbl_Da_BirthDate.Visible = false;
            // 
            // lbl_Da_Address
            // 
            lbl_Da_Address.AutoSize = true;
            lbl_Da_Address.Location = new Point(127, 214);
            lbl_Da_Address.Name = "lbl_Da_Address";
            lbl_Da_Address.Size = new Size(37, 15);
            lbl_Da_Address.TabIndex = 23;
            lbl_Da_Address.Text = "Adres";
            lbl_Da_Address.Visible = false;
            // 
            // lbl_Da_Email
            // 
            lbl_Da_Email.AutoSize = true;
            lbl_Da_Email.Location = new Point(124, 288);
            lbl_Da_Email.Name = "lbl_Da_Email";
            lbl_Da_Email.Size = new Size(36, 15);
            lbl_Da_Email.TabIndex = 24;
            lbl_Da_Email.Text = "Email";
            lbl_Da_Email.Visible = false;
            // 
            // lbl_Da_City
            // 
            lbl_Da_City.AutoSize = true;
            lbl_Da_City.Location = new Point(127, 251);
            lbl_Da_City.Name = "lbl_Da_City";
            lbl_Da_City.Size = new Size(33, 15);
            lbl_Da_City.TabIndex = 25;
            lbl_Da_City.Text = "Şehir";
            lbl_Da_City.Visible = false;
            // 
            // lbl_Ad
            // 
            lbl_Ad.AutoSize = true;
            lbl_Ad.Location = new Point(16, 29);
            lbl_Ad.Name = "lbl_Ad";
            lbl_Ad.Size = new Size(22, 15);
            lbl_Ad.TabIndex = 0;
            lbl_Ad.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 66);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 140);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "TC Kimlik No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 177);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefon No";
            // 
            // pb_Da_Customer
            // 
            pb_Da_Customer.BackgroundImageLayout = ImageLayout.None;
            pb_Da_Customer.BorderStyle = BorderStyle.FixedSingle;
            pb_Da_Customer.ImageLocation = "D:\\Yazilim\\Yusuf Abi Dersler\\GitProjects\\KocBank\\Properties";
            pb_Da_Customer.Location = new Point(233, 20);
            pb_Da_Customer.Name = "pb_Da_Customer";
            pb_Da_Customer.Size = new Size(106, 135);
            pb_Da_Customer.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Da_Customer.TabIndex = 1;
            pb_Da_Customer.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 103);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 18;
            label8.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 214);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "Adres";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 288);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 251);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 6;
            label6.Text = "Şehir";
            // 
            // CheckingAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 755);
            Controls.Add(groupBox3);
            Controls.Add(lvl_Da_Title);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(dgv_AllAccounts);
            Controls.Add(groupBox1);
            Name = "CheckingAccount";
            Text = "Vadesiz Hesap İşlemleri";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AllAccounts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Da_Customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox txt_Da_CommissionRate;
        private Label label11;
        private Button btn_Da_Add;
        private ComboBox cbx_Currency;
        private TextBox txt_Da_InterestRate;
        private Label label10;
        private Label label7;
        private Label lvl_Da_Title;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txt_SearchGovermentID;
        private Button btn_Da_Take;
        private GroupBox groupBox4;
        private Button btn_Print;
        private Label lbl_IBAN;
        private Label label14;
        private Label lbl_AccountNumber;
        private Label label12;
        private System.Drawing.Printing.PrintDocument printDoc;
        private DataGridView dgv_AllAccounts;
        private GroupBox groupBox1;
        private Label lbl_Da_Name;
        private Label lbl_Da_LastName;
        private Label lbl_Da_GovernmentID;
        private Label lbl_Da_Phone;
        private Label lbl_Da_BirthDate;
        private Label lbl_Da_Address;
        private Label lbl_Da_Email;
        private Label lbl_Da_City;
        private Label lbl_Ad;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pb_Da_Customer;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}