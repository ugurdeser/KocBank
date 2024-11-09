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
    public partial class PaymentAuto : Form
    {
        KocBankContext kocBankContext = new KocBankContext();
        Helper helper = new Helper();
        Customer takencustomer = new Customer();
        public PaymentAuto()
        {
            InitializeComponent();
        }
        private void PaymentAuto_Load(object sender, EventArgs e)
        {
            OrganizationList();
            if (cbx_OrganisationType.SelectedIndex == 0)
            {

                txt_PaymentAmount.Text = "0";
                txt_PaymentAmount.Enabled = false;
            }
            else
            {
                PaymentGenerate();
            }


            cbx_PaymentToCreditCard.Enabled = false;
        }

        private void OrganizationList()
        {
            var organizationList = kocBankContext.Organisations.ToList();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));

            dataTable.Rows.Add(0, "Ödenecek Kurum");

            foreach (var item in organizationList)
            {
                dataTable.Rows.Add(item.ID, item.Customer.Name);
            }

            cbx_OrganisationType.ValueMember = "ID";
            cbx_OrganisationType.DisplayMember = "Name";
            cbx_OrganisationType.DataSource = dataTable;
        }

        private void PaymentGenerate()
        {
            Random rnd = new Random();

            decimal amount = rnd.Next(100, 1000);

            txt_PaymentAmount.Text = amount.ToString();
        }


        private void btn_Take_Click(object sender, EventArgs e)
        {
            takencustomer = kocBankContext.Customers.FirstOrDefault(x => x.GovernmentID == txt_SearchGovermentID.Text);

            if (takencustomer != null)
            {
                MessageBox.Show("Müşteri bulundu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
                LoadCreditCard();
                helper.DgvCreditCardRefresher(takencustomer.ID, dgv_CreditCards);
                helper.DgvAccountRefresher(takencustomer.ID, dgv_Accounts);
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                cbx_PaymentToCreditCard.Enabled = true;
                cbx_PaymentToAccount.Enabled = false;
            }
            else
            {
                cbx_PaymentToCreditCard.Enabled = false;
                cbx_PaymentToAccount.Enabled = true;
            }
        }

        private void cbx_OrganisationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_PaymentAmount.Enabled = true;
            if (cbx_OrganisationType.SelectedIndex == 0)
            {

                txt_PaymentAmount.Text = "0";
                txt_PaymentAmount.Enabled = false;
            }
            else
            {
                PaymentGenerate();
            }
        }

        private void btn_AddPaymentAuto_Click(object sender, EventArgs e)
        {
            int selectedOrganisationID = Convert.ToInt32(cbx_OrganisationType.SelectedValue);
            int selectedAccountID = Convert.ToInt32(cbx_PaymentToAccount.SelectedValue);
            int selectedCreditCardID = Convert.ToInt32(cbx_PaymentToCreditCard.SelectedValue);

            if (selectedOrganisationID == 0)
            {
                MessageBox.Show("Ödenecek kurumu seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedAccountID == 0 && selectedCreditCardID == 0)
            {
                MessageBox.Show("Ödeme yapılacak hesabı veya kredi kartını seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Model.MoneyTransfer moneyTransfer = new Model.MoneyTransfer();

            moneyTransfer.CustomerID = takencustomer.ID;
            moneyTransfer.CurrencyID = 1;



        }

        private void LoadAccount()
        {
            var accountList = kocBankContext.Accounts.Where(x => x.CustomerID == takencustomer.ID && x.IsActive == true).ToList();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));

            dataTable.Rows.Add(0, "Hesap Seçiniz");

            foreach (var item in accountList)
            {
                dataTable.Rows.Add(item.ID, "**** " + item.AccountNumber.Substring(14) + " " + item.Currency.Name);
            }

            cbx_PaymentToAccount.ValueMember = "ID";
            cbx_PaymentToAccount.DisplayMember = "Name";
            cbx_PaymentToAccount.DataSource = dataTable;
        }

        private void LoadCreditCard()
        {
            var creditCardList = kocBankContext.CreditCards.Where(x => x.CustomerID == takencustomer.ID && x.IsActive == true).ToList();

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));

            dataTable.Rows.Add(0, "Kredi Kartı Seçiniz");

            foreach (var item in creditCardList)
            {
                dataTable.Rows.Add(item.ID, "**** " + item.CardNumber.Substring(12) + " " + item.CardType.Name);
            }

            cbx_PaymentToCreditCard.ValueMember = "ID";
            cbx_PaymentToCreditCard.DisplayMember = "Name";
            cbx_PaymentToCreditCard.DataSource = dataTable;
        }
    }
}
