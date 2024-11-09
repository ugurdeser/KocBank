namespace KocBank
{
    partial class Deposit_Withdrawal
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
            label2 = new Label();
            dgv_AllAccounts = new DataGridView();
            groupBox2 = new GroupBox();
            btn_clear = new Button();
            label9 = new Label();
            txt_SearchGovermentID = new TextBox();
            btn_Take = new Button();
            groupBox1 = new GroupBox();
            btn_AllWithDrawal = new Button();
            label4 = new Label();
            txt_Amount = new TextBox();
            btn_Accept = new Button();
            label3 = new Label();
            cbx_Type = new ComboBox();
            dgv_AccountDetail = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_AllAccounts).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AccountDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Dutch801 XBd BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(311, 24);
            label1.Name = "label1";
            label1.Size = new Size(537, 35);
            label1.TabIndex = 29;
            label1.Text = "KOÇBANK BANKO PARA İŞLEMLERİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Courier New", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(144, 389);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 36;
            label2.Text = "HESAPLAR";
            // 
            // dgv_AllAccounts
            // 
            dgv_AllAccounts.AllowUserToAddRows = false;
            dgv_AllAccounts.AllowUserToDeleteRows = false;
            dgv_AllAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AllAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AllAccounts.Location = new Point(12, 414);
            dgv_AllAccounts.Name = "dgv_AllAccounts";
            dgv_AllAccounts.RowHeadersVisible = false;
            dgv_AllAccounts.Size = new Size(426, 242);
            dgv_AllAccounts.TabIndex = 35;
            dgv_AllAccounts.CellClick += dgv_AllAccounts_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_SearchGovermentID);
            groupBox2.Controls.Add(btn_Take);
            groupBox2.Location = new Point(226, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 149);
            groupBox2.TabIndex = 34;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_AllWithDrawal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_Amount);
            groupBox1.Controls.Add(btn_Accept);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbx_Type);
            groupBox1.Location = new Point(623, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 205);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "İşlem";
            // 
            // btn_AllWithDrawal
            // 
            btn_AllWithDrawal.Location = new Point(90, 145);
            btn_AllWithDrawal.Name = "btn_AllWithDrawal";
            btn_AllWithDrawal.Size = new Size(108, 23);
            btn_AllWithDrawal.TabIndex = 5;
            btn_AllWithDrawal.Text = "Tüm Parayı Getir";
            btn_AllWithDrawal.UseVisualStyleBackColor = true;
            btn_AllWithDrawal.Click += btn_AllWithDrawal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 102);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 4;
            label4.Text = "Tutar";
            // 
            // txt_Amount
            // 
            txt_Amount.Location = new Point(164, 99);
            txt_Amount.Name = "txt_Amount";
            txt_Amount.Size = new Size(185, 23);
            txt_Amount.TabIndex = 3;
            // 
            // btn_Accept
            // 
            btn_Accept.Location = new Point(241, 145);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(108, 23);
            btn_Accept.TabIndex = 2;
            btn_Accept.Text = "Onay";
            btn_Accept.UseVisualStyleBackColor = true;
            btn_Accept.Click += btn_Accept_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 55);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 1;
            label3.Text = "İşlem Türü";
            // 
            // cbx_Type
            // 
            cbx_Type.FormattingEnabled = true;
            cbx_Type.Location = new Point(164, 52);
            cbx_Type.Name = "cbx_Type";
            cbx_Type.Size = new Size(185, 23);
            cbx_Type.TabIndex = 0;
            // 
            // dgv_AccountDetail
            // 
            dgv_AccountDetail.AllowUserToAddRows = false;
            dgv_AccountDetail.AllowUserToDeleteRows = false;
            dgv_AccountDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AccountDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AccountDetail.Location = new Point(444, 414);
            dgv_AccountDetail.Name = "dgv_AccountDetail";
            dgv_AccountDetail.RowHeadersVisible = false;
            dgv_AccountDetail.Size = new Size(702, 242);
            dgv_AccountDetail.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Courier New", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(708, 389);
            label5.Name = "label5";
            label5.Size = new Size(175, 22);
            label5.TabIndex = 39;
            label5.Text = "HESAP DETAYLARI";
            // 
            // Deposit_Withdrawal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 755);
            Controls.Add(label5);
            Controls.Add(dgv_AccountDetail);
            Controls.Add(label2);
            Controls.Add(dgv_AllAccounts);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Deposit_Withdrawal";
            Text = "Para Yatırma İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dgv_AllAccounts).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AccountDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView dgv_AllAccounts;
        private GroupBox groupBox2;
        private Button btn_clear;
        private Label label9;
        private TextBox txt_SearchGovermentID;
        private Button btn_Take;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox cbx_Type;
        private TextBox txt_Amount;
        private Button btn_Accept;
        private Label label4;
        private DataGridView dgv_AccountDetail;
        private Label label5;
        private Button btn_AllWithDrawal;
    }
}