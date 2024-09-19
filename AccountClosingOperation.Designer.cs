namespace KocBank
{
    partial class AccountClosingOperation
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
            groupBox2 = new GroupBox();
            btn_clear = new Button();
            label9 = new Label();
            txt_SearchGovermentID = new TextBox();
            btn_Take = new Button();
            dgv_AllAccounts = new DataGridView();
            dgv_AccountDetail = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btn_Close = new Button();
            txt_Balance = new TextBox();
            label4 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AllAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_AccountDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Dutch801 XBd BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(377, 11);
            label1.Name = "label1";
            label1.Size = new Size(405, 35);
            label1.TabIndex = 28;
            label1.Text = "KOÇBANK HESAP KAPANIŞ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_SearchGovermentID);
            groupBox2.Controls.Add(btn_Take);
            groupBox2.Location = new Point(407, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 149);
            groupBox2.TabIndex = 29;
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
            // dgv_AllAccounts
            // 
            dgv_AllAccounts.AllowUserToAddRows = false;
            dgv_AllAccounts.AllowUserToDeleteRows = false;
            dgv_AllAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AllAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AllAccounts.Location = new Point(12, 256);
            dgv_AllAccounts.Name = "dgv_AllAccounts";
            dgv_AllAccounts.Size = new Size(1134, 171);
            dgv_AllAccounts.TabIndex = 31;
            dgv_AllAccounts.Click += dgv_AllAccounts_Click;
            // 
            // dgv_AccountDetail
            // 
            dgv_AccountDetail.AllowUserToAddRows = false;
            dgv_AccountDetail.AllowUserToDeleteRows = false;
            dgv_AccountDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AccountDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AccountDetail.Enabled = false;
            dgv_AccountDetail.Location = new Point(12, 475);
            dgv_AccountDetail.Name = "dgv_AccountDetail";
            dgv_AccountDetail.Size = new Size(1134, 171);
            dgv_AccountDetail.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Courier New", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(530, 221);
            label2.Name = "label2";
            label2.Size = new Size(98, 22);
            label2.TabIndex = 33;
            label2.Text = "HESAPLAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Courier New", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(519, 440);
            label3.Name = "label3";
            label3.Size = new Size(120, 22);
            label3.TabIndex = 34;
            label3.Text = "HESAP ÖZET";
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(469, 659);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(221, 23);
            btn_Close.TabIndex = 24;
            btn_Close.Text = "Hesabi Kapat";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // txt_Balance
            // 
            txt_Balance.Enabled = false;
            txt_Balance.ForeColor = Color.Red;
            txt_Balance.Location = new Point(966, 446);
            txt_Balance.Name = "txt_Balance";
            txt_Balance.Size = new Size(180, 23);
            txt_Balance.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(882, 449);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 36;
            label4.Text = "Borç Durumu";
            // 
            // AccountClosingOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1158, 755);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(txt_Balance);
            Controls.Add(btn_Close);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgv_AccountDetail);
            Controls.Add(dgv_AllAccounts);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Name = "AccountClosingOperation";
            Text = "Hesap Kapama";
            WindowState = FormWindowState.Maximized;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AllAccounts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_AccountDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox txt_SearchGovermentID;
        private Button btn_Take;
        private DataGridView dgv_AllAccounts;
        private DataGridView dgv_AccountDetail;
        private Label label2;
        private Label label3;
        private Button btn_Close;
        private Button btn_clear;
        private TextBox txt_Balance;
        private Label label4;
    }
}