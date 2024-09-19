using Castle.Core.Resource;
using KocBank.Context;
using KocBank.Model;
using KocBank.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KocBank
{
    public partial class AccountOpeningOperations : Form
    {
        KocBankContext kocBankContext = new KocBankContext();
        Helper helper = new Helper();
        BankBranch BankBranch = new BankBranch();
        public AccountOpeningOperations()
        {
            InitializeComponent();
        }

        private void DepositAccount_Load(object sender, EventArgs e)
        {

            CmbCurrencyLoad();
            CmbAccountTypeLoad();
        }

        private void CmbAccountTypeLoad()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(-1, "Hesap Türü Seçiniz!");
            foreach (var item in kocBankContext.AccountTypes)
            {
                dt.Rows.Add(item.ID, item.Name);
            }
            cbx_AccountType.ValueMember = "ID";
            cbx_AccountType.DisplayMember = "Name";

            cbx_AccountType.DataSource = dt;
        }

        private void CmbCurrencyLoad()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(-1, "Para Birimi Seçiniz!");
            foreach (var item in kocBankContext.Currencies)
            {
                dt.Rows.Add(item.ID, item.Name);
            }
            cbx_Currency.ValueMember = "ID";
            cbx_Currency.DisplayMember = "Name";

            cbx_Currency.DataSource = dt;
        }


        private void btn_Da_Take_Click(object sender, EventArgs e)
        {
            Customer takencustomer = new Customer();

            takencustomer = kocBankContext.Customers.FirstOrDefault(x => x.GovernmentID == txt_SearchGovermentID.Text);

            if (takencustomer != null)
            {
                lbl_Da_Name.Visible = true;
                lbl_Da_Name.Text = takencustomer.Name;
                lbl_Da_LastName.Visible = true;
                lbl_Da_LastName.Text = takencustomer.Surname;
                lbl_Da_BirthDate.Visible = true;
                lbl_Da_BirthDate.Text = takencustomer.BirthDate.ToShortDateString();
                lbl_Da_GovernmentID.Visible = true;
                lbl_Da_GovernmentID.Text = takencustomer.GovernmentID;
                lbl_Da_Phone.Visible = true;
                lbl_Da_Phone.Text = takencustomer.PhoneNumber;
                lbl_Da_Address.Visible = true;
                lbl_Da_Address.Text = takencustomer.Address;
                lbl_Da_City.Visible = true;
                lbl_Da_City.Text = takencustomer.City.Name;
                lbl_Da_Email.Visible = true;
                lbl_Da_Email.Text = takencustomer.Email;
                pb_Da_Customer.Image = helper.ByteArrayToImage(takencustomer.CustomerPicture);

            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (takencustomer != null)
            {
                helper.DgvAccountRefresher(takencustomer.ID,dgv_AllAccounts);
            }


        }

        

        private void btn_Da_Add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            BankBranch bankBranch = new BankBranch();
            bankBranch = kocBankContext.BankBranches.FirstOrDefault(x => x.BranchCode == 5678);
            customer = kocBankContext.Customers.FirstOrDefault(x => x.GovernmentID == txt_SearchGovermentID.Text);
            if (customer == null)
            {
                MessageBox.Show("Müşteri TC Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var accountNumber = helper.CreateAccountNumber(customer);
            var IBAN = helper.CreateIBAN(accountNumber.ToString());

            //Account account = new Account
            //{
            //    AccountTypeID = 1,
            //    BankBranchID = bankBranch.ID,
            //    BankBranchCode =bankBranch.BranchCode,
            //    CustomerID = Customer.ID,
            //    CurrencyID = Convert.ToInt32(cbx_Currency.SelectedValue),
            //    InterestRate = Convert.ToDecimal(txt_Da_InterestRate.Text),
            //    CommissionRate = Convert.ToDecimal(txt_Da_CommissionRate.Text),
            //    AccountNumber = acountNumber,
            //    IBAN = IBAN,
            //    Balance = 0,
            //    CreatedDate = DateTime.Now
            //};

            Account account = new Account();
            if (Convert.ToInt32(cbx_AccountType.SelectedValue) == -1)
            {
                MessageBox.Show("Hesap Türü Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            account.AccountTypeID = Convert.ToInt32(cbx_AccountType.SelectedValue);
            account.BankBranchID = bankBranch.ID;
            account.BankBranchCode = bankBranch.BranchCode;
            account.CustomerID = customer.ID;
            if (Convert.ToInt32(cbx_Currency.SelectedValue) == -1)
            {
                MessageBox.Show("Para Birimi Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            account.CurrencyID = Convert.ToInt32(cbx_Currency.SelectedValue);
            account.InterestRate = Convert.ToDecimal(txt_Da_InterestRate.Text == "" ? "0.00" : txt_Da_InterestRate.Text);
            account.CommissionRate = Convert.ToDecimal(txt_Da_CommissionRate.Text == "" ? "0.00" : txt_Da_CommissionRate.Text);
            account.AccountNumber = accountNumber;
            account.IBAN = IBAN;
            account.Balance = 0;
            account.IsActive = true;
            account.CreatedDate = DateTime.Now;

            // Account nesnesinin durumunu kontrol et
            var state = kocBankContext.Entry(account).State;
            // State'in ne olduğunu görebilirsiniz. Normalde ekleme öncesi Unchanged olmalı, Add metodunu çağırdıktan sonra ise Added olmalı.
            Console.WriteLine("Account State: " + state); // Durumu görmek için

            lbl_AccountNumber.Text = account.AccountNumber;
            lbl_AccountNumber.Visible = true;
            lbl_IBAN.Text = account.IBAN;
            lbl_IBAN.Visible = true;

            kocBankContext.Add(account);
            kocBankContext.SaveChanges();
            helper.DgvAccountRefresher(customer.ID, dgv_AllAccounts);
            MessageBox.Show("Hesap Oluşturuldu", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void cbx_AccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbx_AccountType.SelectedValue) == 2)
            {
                txt_Da_InterestRate.Text = "0";
                txt_Da_CommissionRate.Text = "0";
                txt_Da_InterestRate.Enabled = false;
                txt_Da_CommissionRate.Enabled = false;
            }
            else
            {
                txt_Da_InterestRate.Enabled = true;
                txt_Da_CommissionRate.Enabled = true;
            }
        }

        //private void btn_Print_Click(object sender, EventArgs e)
        //{
        //    //Print Document lbl_AccountNumber.Text ve lbl_IBAN.Text değerlerini yazdırır.

        //    PrintDocument pd = new PrintDocument();
        //    pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
        //    pd.Print();
        //}

        //void pd_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    // Yazdırılacak metinleri ayarla
        //    string accountNumber = "Hesap Numarası: " + lbl_AccountNumber.Text;
        //    string iban = "IBAN: " + lbl_IBAN.Text;

        //    // Yazdırma alanı için font ve pozisyon ayarları
        //    Font font = new Font("Arial", 12);
        //    float x = 100;
        //    float y = 100;

        //    // Hesap Numarası ve IBAN bilgilerini yazdır
        //    e.Graphics.DrawString(accountNumber, font, Brushes.Black, x, y);
        //    e.Graphics.DrawString(iban, font, Brushes.Black, x, y + 30); // Biraz aşağıya yazdırmak için y+30

        //    // Daha fazla sayfa yazdırılmayacaksa:
        //    e.HasMorePages = false;
        //}
    }
}
