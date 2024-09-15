namespace KocBank
{
    partial class CustomerPage
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
            groupBox1 = new GroupBox();
            btn_Clear = new Button();
            btn_Delete = new Button();
            cbx_Cities = new ComboBox();
            dtp_BirthDay = new DateTimePicker();
            label8 = new Label();
            pb_Customer = new PictureBox();
            btn_Add = new Button();
            btn_PicturesAdder = new Button();
            txt_FileLocation = new TextBox();
            label7 = new Label();
            txt_Email = new TextBox();
            txt_Address = new TextBox();
            txt_Phone = new TextBox();
            txt_GovermentID = new TextBox();
            txt_LastName = new TextBox();
            txt_FirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_Ad = new Label();
            btn_Take = new Button();
            groupBox2 = new GroupBox();
            label9 = new Label();
            txt_SearchGovermentID = new TextBox();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Customer).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Clear);
            groupBox1.Controls.Add(btn_Delete);
            groupBox1.Controls.Add(cbx_Cities);
            groupBox1.Controls.Add(dtp_BirthDay);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pb_Customer);
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(btn_PicturesAdder);
            groupBox1.Controls.Add(txt_FileLocation);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(txt_Address);
            groupBox1.Controls.Add(txt_Phone);
            groupBox1.Controls.Add(txt_GovermentID);
            groupBox1.Controls.Add(txt_LastName);
            groupBox1.Controls.Add(txt_FirstName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_Ad);
            groupBox1.Location = new Point(12, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 510);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Ekle";
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(411, 474);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(342, 23);
            btn_Clear.TabIndex = 24;
            btn_Clear.Text = "Temizle";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.FlatStyle = FlatStyle.System;
            btn_Delete.Location = new Point(585, 445);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(168, 23);
            btn_Delete.TabIndex = 21;
            btn_Delete.Text = "Sil";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // cbx_Cities
            // 
            cbx_Cities.FormattingEnabled = true;
            cbx_Cities.Location = new Point(122, 348);
            cbx_Cities.Name = "cbx_Cities";
            cbx_Cities.Size = new Size(248, 23);
            cbx_Cities.TabIndex = 20;
            // 
            // dtp_BirthDay
            // 
            dtp_BirthDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtp_BirthDay.Location = new Point(122, 152);
            dtp_BirthDay.Name = "dtp_BirthDay";
            dtp_BirthDay.Size = new Size(248, 23);
            dtp_BirthDay.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 155);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 18;
            label8.Text = "Doğum Tarihi";
            // 
            // pb_Customer
            // 
            pb_Customer.BackgroundImageLayout = ImageLayout.None;
            pb_Customer.BorderStyle = BorderStyle.FixedSingle;
            pb_Customer.ImageLocation = "D:\\Yazilim\\Yusuf Abi Dersler\\GitProjects\\KocBank\\Properties";
            pb_Customer.Location = new Point(403, 43);
            pb_Customer.Name = "pb_Customer";
            pb_Customer.Size = new Size(362, 375);
            pb_Customer.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Customer.TabIndex = 1;
            pb_Customer.TabStop = false;
            // 
            // btn_Add
            // 
            btn_Add.FlatStyle = FlatStyle.System;
            btn_Add.Location = new Point(411, 445);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(168, 23);
            btn_Add.TabIndex = 17;
            btn_Add.Text = "Kaydet";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_PicturesAdder
            // 
            btn_PicturesAdder.Location = new Point(366, 446);
            btn_PicturesAdder.Name = "btn_PicturesAdder";
            btn_PicturesAdder.Size = new Size(31, 23);
            btn_PicturesAdder.TabIndex = 16;
            btn_PicturesAdder.Text = "...";
            btn_PicturesAdder.UseVisualStyleBackColor = true;
            btn_PicturesAdder.Click += btn_PicturesAdder_Click;
            // 
            // txt_FileLocation
            // 
            txt_FileLocation.Location = new Point(122, 446);
            txt_FileLocation.Name = "txt_FileLocation";
            txt_FileLocation.Size = new Size(248, 23);
            txt_FileLocation.TabIndex = 15;
            txt_FileLocation.TextChanged += txt_FileLocation_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 453);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 14;
            label7.Text = "Kimlik Ekle";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(122, 397);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(248, 23);
            txt_Email.TabIndex = 13;
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(122, 299);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(248, 23);
            txt_Address.TabIndex = 11;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(122, 250);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(248, 23);
            txt_Phone.TabIndex = 10;
            // 
            // txt_GovermentID
            // 
            txt_GovermentID.Location = new Point(122, 201);
            txt_GovermentID.Name = "txt_GovermentID";
            txt_GovermentID.Size = new Size(248, 23);
            txt_GovermentID.TabIndex = 9;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(122, 103);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(248, 23);
            txt_LastName.TabIndex = 8;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(122, 54);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(248, 23);
            txt_FirstName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 351);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 6;
            label6.Text = "Şehir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 400);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 302);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 4;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 253);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefon No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 204);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "TC Kimlik No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 106);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Soyad";
            // 
            // lbl_Ad
            // 
            lbl_Ad.AutoSize = true;
            lbl_Ad.Location = new Point(25, 57);
            lbl_Ad.Name = "lbl_Ad";
            lbl_Ad.Size = new Size(22, 15);
            lbl_Ad.TabIndex = 0;
            lbl_Ad.Text = "Ad";
            // 
            // btn_Take
            // 
            btn_Take.Location = new Point(112, 106);
            btn_Take.Name = "btn_Take";
            btn_Take.Size = new Size(126, 23);
            btn_Take.TabIndex = 22;
            btn_Take.Text = "Getir";
            btn_Take.UseVisualStyleBackColor = true;
            btn_Take.Click += btn_Take_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_SearchGovermentID);
            groupBox2.Controls.Add(btn_Take);
            groupBox2.Location = new Point(793, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 149);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Getir";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(138, 33);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 22;
            label9.Text = "TC Kimlik No";
            // 
            // txt_SearchGovermentID
            // 
            txt_SearchGovermentID.Location = new Point(42, 64);
            txt_SearchGovermentID.Name = "txt_SearchGovermentID";
            txt_SearchGovermentID.Size = new Size(267, 23);
            txt_SearchGovermentID.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(793, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(353, 302);
            dataGridView1.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(878, 280);
            label10.Name = "label10";
            label10.Size = new Size(182, 25);
            label10.TabIndex = 25;
            label10.Text = "MÜŞTERİ UYARILARI";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label11.Location = new Point(392, 40);
            label11.Name = "label11";
            label11.Size = new Size(339, 32);
            label11.TabIndex = 26;
            label11.Text = "KOÇBANK MÜŞTERİ SAYFASI";
            // 
            // CustomerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 755);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label11);
            MinimizeBox = false;
            Name = "CustomerPage";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Müşteri Sayfası";
            WindowState = FormWindowState.Maximized;
            Load += CustomerPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Customer).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_Ad;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txt_Email;
        private TextBox txt_Address;
        private TextBox txt_Phone;
        private TextBox txt_GovermentID;
        private TextBox txt_LastName;
        private TextBox txt_FirstName;
        private Label label7;
        private Button btn_PicturesAdder;
        private TextBox txt_FileLocation;
        private Button btn_Add;
        private PictureBox pb_Customer;
        private Label label8;
        private DateTimePicker dtp_BirthDay;
        private ComboBox cbx_Cities;
        private Button btn_Delete;
        private Button btn_Take;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txt_SearchGovermentID;
        private DataGridView dataGridView1;
        private Label label10;
        private Label label11;
        private Button btn_Clear;
    }
}