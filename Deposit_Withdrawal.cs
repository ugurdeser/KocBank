using KocBank.Context;
using KocBank.Model;
using KocBank.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KocBank
{
    public partial class Deposit_Withdrawal : Form
    {
        Helper helper = new Helper();
        KocBankContext kocBankContext = new KocBankContext();
        public Deposit_Withdrawal()
        {
            InitializeComponent();
            cbx_TypeLoader();
        }

        private void cbx_TypeLoader()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(0, "İşlem Tipi Seçiniz!");
            dt.Rows.Add(1, "Para Yatırma");
            dt.Rows.Add(2, "Para Çekme");

            cbx_Type.ValueMember = "ID";
            cbx_Type.DisplayMember = "Name";
            cbx_Type.DataSource = dt;



        }

        private void btn_Take_Click(object sender, EventArgs e)
        {
            Customer takencustomer = new Customer();

            takencustomer = kocBankContext.Customers.FirstOrDefault(x => x.GovernmentID == txt_SearchGovermentID.Text);

            if (takencustomer != null)
            {
                helper.DgvAccountRefresher(takencustomer.ID, dgv_AllAccounts);
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_SearchGovermentID.Text = "";
            dgv_AllAccounts.DataSource = null;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            int moneyTransferType = 0;
            decimal amount = 0;
            int accountID = 0;
            Account account = new Account();
            AccountTransaction accountTransaction = new AccountTransaction();
            Model.MoneyTransfer moneyTransfer = new Model.MoneyTransfer();

            string txtFirst = txt_Amount.Text.Replace(",", ".");
            moneyTransferType = cbx_Type.SelectedIndex;
            if (!decimal.TryParse(txtFirst, out decimal result))
            {
                MessageBox.Show("Lütfen geçerli bir miktar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            amount = Convert.ToDecimal(txtFirst);

            if (dgv_AllAccounts.CurrentRow == null || dgv_AllAccounts.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Lütfen bir hesap seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                accountID = Convert.ToInt32(dgv_AllAccounts.CurrentRow.Cells[0].Value);
                account = kocBankContext.Accounts.FirstOrDefault(x => x.ID == accountID);
            }



            if (moneyTransferType == 0)
            {
                MessageBox.Show("Lütfen işlem tipi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (moneyTransferType == 1)
            {
                accountTransaction.AccountID = accountID;
                accountTransaction.Amount = amount;
                accountTransaction.CreatedDate = DateTime.Now;
                accountTransaction.TransactionTypeID = 1;

                moneyTransfer.ReceiverAccountNumber = account.AccountNumber;
                moneyTransfer.SenderAccountNumber = null;
                moneyTransfer.Amount = amount;
                moneyTransfer.CreatedDate = DateTime.Now;
                moneyTransfer.CurrencyID = account.CurrencyID;
                moneyTransfer.TransferTypeID = 1;
                moneyTransfer.Description = "Bankodan Para Yatırma";

                kocBankContext.AccountTransactions.Add(accountTransaction);
                kocBankContext.MoneyTransfers.Add(moneyTransfer);
                kocBankContext.SaveChanges();

                MessageBox.Show("Para yatırma işlemi başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (moneyTransferType == 2)
            {
                decimal balance = 0;
                List<AccountTransaction> accountTransactions = kocBankContext.AccountTransactions.Where(x => x.AccountID == accountID).ToList();
                balance = (accountTransactions.Where(x => x.TransactionTypeID == 1).Sum(x => x.Amount)) - (accountTransactions.Where(x => x.TransactionTypeID == 2).Sum(x => x.Amount));

                account.Balance = balance;

                if (account.Balance < amount)
                {
                    MessageBox.Show("Hesabınızda yeterli bakiye bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                accountTransaction.AccountID = accountID;
                accountTransaction.Amount = amount;
                accountTransaction.CreatedDate = DateTime.Now;
                accountTransaction.TransactionTypeID = 2;

                moneyTransfer.ReceiverAccountNumber = null;
                moneyTransfer.SenderAccountNumber = account.AccountNumber;
                moneyTransfer.Amount = amount;
                moneyTransfer.CreatedDate = DateTime.Now;
                moneyTransfer.CurrencyID = account.CurrencyID;
                moneyTransfer.TransferTypeID = 2;
                moneyTransfer.Description = "Bankodan Para Çekme";

                kocBankContext.AccountTransactions.Add(accountTransaction);
                kocBankContext.MoneyTransfers.Add(moneyTransfer);
                kocBankContext.SaveChanges();

                MessageBox.Show("Para çekme işlemi başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen işlem tipi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
