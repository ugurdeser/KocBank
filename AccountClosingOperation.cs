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
    public partial class AccountClosingOperation : Form
    {
        Helper helper = new Helper();
        KocBankContext kocBankContext = new KocBankContext();
        public AccountClosingOperation()
        {
            InitializeComponent();
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            int acountID = 0;
            decimal balance = 0;
            if (dgv_AllAccounts.CurrentRow == null || dgv_AllAccounts.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Lütfen bir hesap seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                acountID = Convert.ToInt32(dgv_AllAccounts.CurrentRow.Cells[0].Value);
            }


            if (MessageBox.Show("Hesap kapatılsın mı?", "Hesap Kapatma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Account account = new Account();
                account = kocBankContext.Accounts.FirstOrDefault(x => x.ID == acountID);

                List<AccountTransaction> accountTransactions = kocBankContext.AccountTransactions.Where(x => x.AccountID == acountID).ToList();
                balance = (accountTransactions.Where(x => x.TransactionTypeID == 1).Sum(x => x.Amount)) - (accountTransactions.Where(x => x.TransactionTypeID == 2).Sum(x => x.Amount));
                account.Balance = balance;

                if (account.Balance < 0)
                {
                    MessageBox.Show("Hesabınızda borç bulunmaktadır. Lütfen borcunuzu ödeyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (account.Balance > 0)
                {
                    MessageBox.Show("Hesapta paranız bulunmaktadır. Paranızı çekiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    account.IsActive = false;
                    kocBankContext.Accounts.Update(account);
                    kocBankContext.SaveChanges();
                    MessageBox.Show("Hesap kapatıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            helper.DgvAccountRefresher(acountID, dgv_AllAccounts);
        }

        private void dgv_AllAccounts_Click(object sender, EventArgs e)
        {
            int accountId = 0;
            decimal balance = 0;

            if (dgv_AllAccounts.CurrentRow == null || dgv_AllAccounts.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Lütfen bir hesap seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                accountId = Convert.ToInt32(dgv_AllAccounts.CurrentRow.Cells[0].Value);
                List<AccountTransaction> accountTransactions = kocBankContext.AccountTransactions.Where(x => x.AccountID == accountId).ToList();
                balance = (accountTransactions.Where(x => x.TransactionTypeID == 1).Sum(x => x.Amount)) - (accountTransactions.Where(x => x.TransactionTypeID == 2).Sum(x => x.Amount));
                txt_Balance.Text = balance.ToString();
            }

            helper.DgvAcountDetailRefresher(accountId, dgv_AccountDetail);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_SearchGovermentID.Text = "";
            dgv_AllAccounts.DataSource = null;
            dgv_AccountDetail.DataSource = null;
        }
    }
}
