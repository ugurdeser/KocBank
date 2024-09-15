using Castle.Core.Resource;
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
    public partial class DepositAccount : Form
    {
        KocBankContext kocBankContext = new KocBankContext();
        Helper helper = new Helper();
        BankBranch BankBranch = new BankBranch();
        public DepositAccount()
        {
            InitializeComponent();
        }

        private void DepositAccount_Load(object sender, EventArgs e)
        {
            CmbLoad();
        }

        private void CmbLoad()
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
            Customer customer = new Customer();

            customer = kocBankContext.Customers.FirstOrDefault(x => x.GovernmentID == txt_SearchGovermentID.Text);

            if (customer != null)
            {
                lbl_Da_Name.Visible = true;
                lbl_Da_Name.Text = customer.Name;
                lbl_Da_LastName.Visible = true;
                lbl_Da_LastName.Text = customer.Surname;
                lbl_Da_BirthDate.Visible = true;
                lbl_Da_BirthDate.Text = customer.BirthDate.ToShortDateString();
                lbl_Da_GovernmentID.Visible = true;
                lbl_Da_GovernmentID.Text = customer.GovernmentID;
                lbl_Da_Phone.Visible = true;
                lbl_Da_Phone.Text = customer.PhoneNumber;
                lbl_Da_Address.Visible = true;
                lbl_Da_Address.Text = customer.Address;
                lbl_Da_City.Visible = true;
                lbl_Da_City.Text = customer.City.Name;
                lbl_Da_Email.Visible = true;
                lbl_Da_Email.Text = customer.Email;
                pb_Da_Customer.Image = helper.ByteArrayToImage(customer.CustomerPicture);

            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }

            DgvRefresher(customer);


        }

        private void DgvRefresher(Customer customer)
        {
            DataTable dt = new DataTable();

            var usersAccount = kocBankContext.Accounts.Where(x => x.CustomerID == customer.ID).ToList();

            dt.Columns.Add("ID");
            dt.Columns.Add("HesapTürü");
            dt.Columns.Add("Faiz Oranı");
            dt.Columns.Add("Komisyon Oranı");
            dt.Columns.Add("Hesap Numarasi");
            dt.Columns.Add("IBAN");
            dt.Columns.Add("Açılış Tarihi");


            foreach (var item in usersAccount)
            {
                dt.NewRow();


                dt.Rows.Add(item.ID, item.AccountType.Name, item.InterestRate, item.CommissionRate, item.AccountNumber, item.IBAN, item.CreatedDate.ToShortDateString());

            }
            dgv_AllAccounts.DataSource = dt;
            dgv_AllAccounts.Columns["ID"].Width = 30;
            dgv_AllAccounts.Columns["Faiz Oranı"].Width = 50;
            dgv_AllAccounts.Columns["Komisyon Oranı"].Width = 50;
        }

        private void btn_Da_Add_Click(object sender, EventArgs e)
        {
            var customer = kocBankContext.Customers.FirstOrDefault(x => x.GovernmentID == txt_SearchGovermentID.Text);
            var acountNumber = helper.CreateAccountNumber(customer);
            var IBAN = helper.CreateIBAN(acountNumber.ToString());

            var bankBranch = kocBankContext.BankBranches.FirstOrDefault(x => x.ID == 2);

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

            account.AccountTypeID = 1;
            account.BankBranchID = bankBranch.ID;
            account.BankBranchCode = bankBranch.BranchCode;
            account.CustomerID = customer.ID;
            account.CurrencyID = Convert.ToInt32(cbx_Currency.SelectedValue);
            account.InterestRate = Convert.ToDecimal(txt_Da_InterestRate.Text);
            account.CommissionRate = Convert.ToDecimal(txt_Da_CommissionRate.Text);
            account.AccountNumber = acountNumber;
            account.IBAN = IBAN;
            account.Balance = 0;
            account.CreatedDate = DateTime.Now;


            lbl_AccountNumber.Text = account.AccountNumber;
            lbl_IBAN.Text = account.IBAN;

            kocBankContext.Accounts.AddRange(account);
            kocBankContext.SaveChanges();
            MessageBox.Show("Hesap Oluşturuldu");

            DgvRefresher(customer);



        }


    }
}
