namespace KocBank
{
    partial class PaymentAuto
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
            checkBox2 = new CheckBox();
            label4 = new Label();
            cbx_PaymentToCreditCard = new ComboBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            cbx_PaymentToAccount = new ComboBox();
            label12 = new Label();
            cbx_OrganisationType = new ComboBox();
            label11 = new Label();
            txt_PaymentAmount = new TextBox();
            btn_AddPaymentAuto = new Button();
            dgv_CreditCards = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btn_clear = new Button();
            label9 = new Label();
            txt_SearchGovermentID = new TextBox();
            btn_Take = new Button();
            dgv_Accounts = new DataGridView();
            label5 = new Label();
            dgv_paymentAuto = new DataGridView();
            label6 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CreditCards).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Accounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_paymentAuto).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cbx_PaymentToCreditCard);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cbx_PaymentToAccount);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(cbx_OrganisationType);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txt_PaymentAmount);
            groupBox3.Controls.Add(btn_AddPaymentAuto);
            groupBox3.Location = new Point(12, 153);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 313);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "OTOMATİK ÖDEME TALİMATLARI";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(25, 215);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(151, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "KREDİ KARTI İLE ÖDEME";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 183);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 11;
            label4.Text = "ÖDENECEK KREDİ KARTI";
            // 
            // cbx_PaymentToCreditCard
            // 
            cbx_PaymentToCreditCard.FormattingEnabled = true;
            cbx_PaymentToCreditCard.Location = new Point(164, 180);
            cbx_PaymentToCreditCard.Name = "cbx_PaymentToCreditCard";
            cbx_PaymentToCreditCard.Size = new Size(169, 23);
            cbx_PaymentToCreditCard.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(201, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "OTOMATİK ÖDEME OLARAK EKLE";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 143);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 8;
            label3.Text = "ÖDENECEK HESAP";
            // 
            // cbx_PaymentToAccount
            // 
            cbx_PaymentToAccount.FormattingEnabled = true;
            cbx_PaymentToAccount.Location = new Point(164, 140);
            cbx_PaymentToAccount.Name = "cbx_PaymentToAccount";
            cbx_PaymentToAccount.Size = new Size(169, 23);
            cbx_PaymentToAccount.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 69);
            label12.Name = "label12";
            label12.Size = new Size(110, 15);
            label12.TabIndex = 4;
            label12.Text = "ÖDENECEK KURUM";
            // 
            // cbx_OrganisationType
            // 
            cbx_OrganisationType.FormattingEnabled = true;
            cbx_OrganisationType.Location = new Point(164, 66);
            cbx_OrganisationType.Name = "cbx_OrganisationType";
            cbx_OrganisationType.Size = new Size(169, 23);
            cbx_OrganisationType.TabIndex = 3;
            cbx_OrganisationType.SelectedIndexChanged += cbx_OrganisationType_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 106);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 2;
            label11.Text = "BORÇ";
            // 
            // txt_PaymentAmount
            // 
            txt_PaymentAmount.Location = new Point(164, 103);
            txt_PaymentAmount.Name = "txt_PaymentAmount";
            txt_PaymentAmount.Size = new Size(169, 23);
            txt_PaymentAmount.TabIndex = 1;
            // 
            // btn_AddPaymentAuto
            // 
            btn_AddPaymentAuto.Location = new Point(164, 265);
            btn_AddPaymentAuto.Name = "btn_AddPaymentAuto";
            btn_AddPaymentAuto.Size = new Size(169, 23);
            btn_AddPaymentAuto.TabIndex = 0;
            btn_AddPaymentAuto.Text = "ÖDE";
            btn_AddPaymentAuto.UseVisualStyleBackColor = true;
            btn_AddPaymentAuto.Click += btn_AddPaymentAuto_Click;
            // 
            // dgv_CreditCards
            // 
            dgv_CreditCards.AllowUserToAddRows = false;
            dgv_CreditCards.AllowUserToDeleteRows = false;
            dgv_CreditCards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_CreditCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CreditCards.Location = new Point(12, 507);
            dgv_CreditCards.Name = "dgv_CreditCards";
            dgv_CreditCards.RowHeadersVisible = false;
            dgv_CreditCards.Size = new Size(562, 211);
            dgv_CreditCards.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(213, 475);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 36;
            label1.Text = "KREDİ KARTLARI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Dutch801 XBd BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(307, 65);
            label2.Name = "label2";
            label2.Size = new Size(461, 35);
            label2.TabIndex = 37;
            label2.Text = "KOÇBANK ÖDEME İŞLEMLERİ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_SearchGovermentID);
            groupBox2.Controls.Add(btn_Take);
            groupBox2.Location = new Point(390, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 149);
            groupBox2.TabIndex = 35;
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
            // dgv_Accounts
            // 
            dgv_Accounts.AllowUserToAddRows = false;
            dgv_Accounts.AllowUserToDeleteRows = false;
            dgv_Accounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Accounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Accounts.Location = new Point(584, 507);
            dgv_Accounts.Name = "dgv_Accounts";
            dgv_Accounts.RowHeadersVisible = false;
            dgv_Accounts.Size = new Size(562, 211);
            dgv_Accounts.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(811, 475);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 41;
            label5.Text = "HESAPLAR";
            // 
            // dgv_paymentAuto
            // 
            dgv_paymentAuto.AllowUserToAddRows = false;
            dgv_paymentAuto.AllowUserToDeleteRows = false;
            dgv_paymentAuto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_paymentAuto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_paymentAuto.Location = new Point(741, 153);
            dgv_paymentAuto.Name = "dgv_paymentAuto";
            dgv_paymentAuto.RowHeadersVisible = false;
            dgv_paymentAuto.Size = new Size(405, 313);
            dgv_paymentAuto.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(809, 125);
            label6.Name = "label6";
            label6.Size = new Size(268, 25);
            label6.TabIndex = 44;
            label6.Text = "AKTİF OTOMATİK ÖDEMELER";
            // 
            // PaymentAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 755);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(dgv_paymentAuto);
            Controls.Add(dgv_Accounts);
            Controls.Add(label5);
            Controls.Add(groupBox3);
            Controls.Add(dgv_CreditCards);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Name = "PaymentAuto";
            Text = "Ödeme İşlemleri";
            WindowState = FormWindowState.Maximized;
            Load += PaymentAuto_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CreditCards).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Accounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_paymentAuto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Label label12;
        private ComboBox cbx_OrganisationType;
        private Label label11;
        private TextBox txt_PaymentAmount;
        private Button btn_AddPaymentAuto;
        private DataGridView dgv_CreditCards;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private Button btn_clear;
        private Label label9;
        private TextBox txt_SearchGovermentID;
        private Button btn_Take;
        private Label label3;
        private ComboBox cbx_PaymentToAccount;
        private CheckBox checkBox1;
        private Label label4;
        private ComboBox cbx_PaymentToCreditCard;
        private CheckBox checkBox2;
        private DataGridView dgv_Accounts;
        private Label label5;
        private DataGridView dgv_paymentAuto;
        private Label label6;
    }
}