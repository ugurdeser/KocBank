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
        Customer Customer = new Customer();
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
            Customer = kocBankContext.Customers.FirstOrDefault(x => x.GovernmentID == txt_SearchGovermentID.Text);

            if (Customer != null)
            {
                lbl_Da_Name.Visible = true;
                lbl_Da_Name.Text = Customer.Name;
                lbl_Da_LastName.Visible = true;
                lbl_Da_LastName.Text = Customer.Surname;
                lbl_Da_BirthDate.Visible = true;
                lbl_Da_BirthDate.Text = Customer.BirthDate.ToShortDateString();
                lbl_Da_GovernmentID.Visible = true;
                lbl_Da_GovernmentID.Text = Customer.GovernmentID;
                lbl_Da_Phone.Visible = true;
                lbl_Da_Phone.Text = Customer.PhoneNumber;
                lbl_Da_Address.Visible = true;
                lbl_Da_Address.Text = Customer.Address;
                lbl_Da_City.Visible = true;
                lbl_Da_City.Text = Customer.City.Name;
                lbl_Da_Email.Visible = true;
                lbl_Da_Email.Text = Customer.Email;
                pb_Da_Customer.Image = helper.ByteArrayToImage(Customer.CustomerPicture);

            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
            }
        }

        private void btn_Da_Add_Click(object sender, EventArgs e)
        {
            var acountNumber = helper.CreateAccountNumber(Customer);

            Account account = new Account
            {
                AccountTypeID = 5,
                CustomerID = Customer.ID,
                CurrencyID = Convert.ToInt32(cbx_Currency.SelectedValue),
                InterestRate = Convert.ToDecimal(txt_Da_InterestRate.Text),
                CommissionRate = Convert.ToDecimal(txt_Da_CommissionRate.Text),
                AccountNumber = acountNumber,
                IBAN = helper.CreateIBAN(acountNumber.ToString()),
                Balance = 0,
                CreatedDate = DateTime.Now
            };

            kocBankContext.Accounts.Add(account);
            kocBankContext.SaveChanges();
            MessageBox.Show("Hesap Oluşturuldu");



        }


    }
}
