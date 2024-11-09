namespace KocBank
{
    partial class CreditCardAdd
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
            groupBox2 = new GroupBox();
            btn_clear = new Button();
            label9 = new Label();
            txt_SearchGovermentID = new TextBox();
            btn_Take = new Button();
            label2 = new Label();
            dgv_CreditCards = new DataGridView();
            label1 = new Label();
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pb_Da_Customer = new PictureBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            btn_CreditCardsUpdate = new Button();
            label12 = new Label();
            cbx_CreditCardTypes = new ComboBox();
            label11 = new Label();
            txt_CreditCardLimit = new TextBox();
            btn_AddCreditCard = new Button();
            btn_CreditCardClose = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CreditCards).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Da_Customer).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_SearchGovermentID);
            groupBox2.Controls.Add(btn_Take);
            groupBox2.Location = new Point(407, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 149);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Getir";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(36, 89);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(126, 23);
            btn_clear.TabIndex = 24;
            btn_clear.Text = "Temizle";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
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
            // btn_Take
            // 
            btn_Take.Location = new Point(177, 89);
            btn_Take.Name = "btn_Take";
            btn_Take.Size = new Size(126, 23);
            btn_Take.TabIndex = 22;
            btn_Take.Text = "Getir";
            btn_Take.UseVisualStyleBackColor = true;
            btn_Take.Click += btn_Take_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Dutch801 XBd BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(307, 28);
            label2.Name = "label2";
            label2.Size = new Size(544, 35);
            label2.TabIndex = 31;
            label2.Text = "KOÇBANK KREDİ KARTI İŞLEMLERİ";
            // 
            // dgv_CreditCards
            // 
            dgv_CreditCards.AllowUserToAddRows = false;
            dgv_CreditCards.AllowUserToDeleteRows = false;
            dgv_CreditCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CreditCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CreditCards.Location = new Point(12, 442);
            dgv_CreditCards.Name = "dgv_CreditCards";
            dgv_CreditCards.RowHeadersVisible = false;
            dgv_CreditCards.Size = new Size(1134, 211);
            dgv_CreditCards.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Dutch801 XBd BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(444, 387);
            label1.Name = "label1";
            label1.Size = new Size(271, 35);
            label1.TabIndex = 31;
            label1.Text = "KREDİ KARTLARI";
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
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pb_Da_Customer);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 335);
            groupBox1.TabIndex = 33;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 66);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 140);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 2;
            label4.Text = "TC Kimlik No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 177);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 3;
            label5.Text = "Telefon No";
            // 
            // pb_Da_Customer
            // 
            pb_Da_Customer.BackgroundImageLayout = ImageLayout.None;
            pb_Da_Customer.BorderStyle = BorderStyle.FixedSingle;
            pb_Da_Customer.ImageLocation = "D:\\Yazilim\\Yusuf Abi Dersler\\GitProjects\\KocBank\\Properties";
            pb_Da_Customer.Location = new Point(233, 20);
            pb_Da_Customer.Name = "pb_Da_Customer";
            pb_Da_Customer.Size = new Size(106, 129);
            pb_Da_Customer.SizeMode = PictureBoxSizeMode.StretchImage;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 214);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 4;
            label6.Text = "Adres";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 288);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 251);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 6;
            label10.Text = "Şehir";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_CreditCardClose);
            groupBox3.Controls.Add(btn_CreditCardsUpdate);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(cbx_CreditCardTypes);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txt_CreditCardLimit);
            groupBox3.Controls.Add(btn_AddCreditCard);
            groupBox3.Location = new Point(801, 78);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(345, 335);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kredi Kartı Bilgileri";
            // 
            // btn_CreditCardsUpdate
            // 
            btn_CreditCardsUpdate.Location = new Point(37, 136);
            btn_CreditCardsUpdate.Name = "btn_CreditCardsUpdate";
            btn_CreditCardsUpdate.Size = new Size(129, 23);
            btn_CreditCardsUpdate.TabIndex = 5;
            btn_CreditCardsUpdate.Text = "Güncelle";
            btn_CreditCardsUpdate.UseVisualStyleBackColor = true;
            btn_CreditCardsUpdate.Click += btn_CreditCardsUpdate_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 69);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 4;
            label12.Text = "Kredi Karti Tipi";
            // 
            // cbx_CreditCardTypes
            // 
            cbx_CreditCardTypes.FormattingEnabled = true;
            cbx_CreditCardTypes.Location = new Point(141, 66);
            cbx_CreditCardTypes.Name = "cbx_CreditCardTypes";
            cbx_CreditCardTypes.Size = new Size(169, 23);
            cbx_CreditCardTypes.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 101);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 2;
            label11.Text = "Kredi Karti Limiti";
            // 
            // txt_CreditCardLimit
            // 
            txt_CreditCardLimit.Location = new Point(141, 98);
            txt_CreditCardLimit.Name = "txt_CreditCardLimit";
            txt_CreditCardLimit.Size = new Size(169, 23);
            txt_CreditCardLimit.TabIndex = 1;
            // 
            // btn_AddCreditCard
            // 
            btn_AddCreditCard.Location = new Point(181, 136);
            btn_AddCreditCard.Name = "btn_AddCreditCard";
            btn_AddCreditCard.Size = new Size(129, 23);
            btn_AddCreditCard.TabIndex = 0;
            btn_AddCreditCard.Text = "Ekle";
            btn_AddCreditCard.UseVisualStyleBackColor = true;
            btn_AddCreditCard.Click += btn_AddCreditCard_Click;
            // 
            // btn_CreditCardClose
            // 
            btn_CreditCardClose.Location = new Point(37, 173);
            btn_CreditCardClose.Name = "btn_CreditCardClose";
            btn_CreditCardClose.Size = new Size(273, 23);
            btn_CreditCardClose.TabIndex = 6;
            btn_CreditCardClose.Text = "Kart Kapa";
            btn_CreditCardClose.UseVisualStyleBackColor = true;
            btn_CreditCardClose.Click += btn_CreditCardClose_Click;
            // 
            // CreditCardAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 755);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgv_CreditCards);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Name = "CreditCardAdd";
            Text = "Kredi Kartı Ekleme İşlemleri";
            Load += CreditCardAdd_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CreditCards).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Da_Customer).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_clear;
        private Label label9;
        private TextBox txt_SearchGovermentID;
        private Button btn_Take;
        private Label label2;
        private DataGridView dgv_CreditCards;
        private Label label1;
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
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pb_Da_Customer;
        private Label label8;
        private Label label6;
        private Label label7;
        private Label label10;
        private GroupBox groupBox3;
        private Button btn_AddCreditCard;
        private TextBox txt_CreditCardLimit;
        private Label label11;
        private Label label12;
        private ComboBox cbx_CreditCardTypes;
        private Button btn_CreditCardsUpdate;
        private Button btn_CreditCardClose;
    }
}