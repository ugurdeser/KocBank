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
using System.Web;
using System.Windows.Forms;

namespace KocBank
{
    public partial class CreditCardAdd : Form
    {
        KocBankContext kocBankContext = new KocBankContext();
        Helper helper = new Helper();
        Customer takencustomer = new Customer();

        public CreditCardAdd()
        {
            InitializeComponent();
        }

        private void CreditCardAdd_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(0, "Kart Tipi Seçiniz!");
            foreach (var item in kocBankContext.CardTypes)
            {
                dt.Rows.Add(item.ID, item.Name);
            }
            cbx_CreditCardTypes.ValueMember = "ID";
            cbx_CreditCardTypes.DisplayMember = "Name";

            cbx_CreditCardTypes.DataSource = dt;
        }

        private void btn_Take_Click(object sender, EventArgs e)
        {

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
                helper.DgvCreditCardRefresher(takencustomer.ID, dgv_CreditCards);
            }
        }

        private void btn_AddCreditCard_Click(object sender, EventArgs e)
        {
            CreditCard creditCard = new CreditCard();

            creditCard.CustomerID = takencustomer.ID;
            creditCard.CardNumber = helper.CardNumberGenerator();
            creditCard.CardHolderName = takencustomer.Name + " " + takencustomer.Surname;
            creditCard.ExpirationDate = DateTime.Now.AddYears(5).ToShortDateString();
            creditCard.CVV = helper.CVVGenerator();
            string cardlimit = txt_CreditCardLimit.Text;
            if (!int.TryParse(cardlimit, out int result))
            {
                MessageBox.Show("Limit sadece sayısal değer olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_CreditCardLimit.Text == null || txt_CreditCardLimit.Text == "")
            {
                MessageBox.Show("Limit alanı boş bırakılmasi durumunda Limit 0 olarak atanacaktır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            creditCard.Limit = txt_CreditCardLimit.Text == "" ? 0 : Convert.ToInt32(txt_CreditCardLimit.Text);
            creditCard.Balance = 0;
            if (cbx_CreditCardTypes.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen kart tipi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            creditCard.PaymentDueDate = DateTime.Now.AddMonths(1);
            creditCard.CardTypeID = Convert.ToInt32(cbx_CreditCardTypes.SelectedValue);
            creditCard.CreatedDate = DateTime.Now;

            MessageBox.Show("Kredi Kartı başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            kocBankContext.CreditCards.Add(creditCard);
            kocBankContext.SaveChanges();

            helper.DgvCreditCardRefresher(takencustomer.ID, dgv_CreditCards);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cbx_CreditCardTypes.SelectedIndex = 0;
            txt_SearchGovermentID.Text = "";
            dgv_CreditCards.DataSource = null;

        }

        private void btn_CreditCardsUpdate_Click(object sender, EventArgs e)
        {
            int cardID = 0;
            string cardLimit = "";
            if (dgv_CreditCards.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kredi kartını seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cardID = Convert.ToInt32(dgv_CreditCards.CurrentRow.Cells["ID"].Value);

            var creditCard = kocBankContext.CreditCards.FirstOrDefault(x => x.ID == cardID);
            cardLimit = txt_CreditCardLimit.Text;

            if (creditCard == null)
            {
                MessageBox.Show("Kredi kartı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(cardLimit, out int result))
            {
                MessageBox.Show("Limit sadece sayısal değer olabilir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_CreditCardLimit.Text == null || txt_CreditCardLimit.Text == "")
            {
                MessageBox.Show("Limit alanı boş bırakılmasi durumunda Limit 0 olarak atanacaktır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            creditCard.Limit = Convert.ToInt32(txt_CreditCardLimit.Text);

            kocBankContext.CreditCards.Update(creditCard);
            kocBankContext.SaveChanges();
            helper.DgvCreditCardRefresher(takencustomer.ID, dgv_CreditCards);

        }

        private void btn_CreditCardClose_Click(object sender, EventArgs e)
        {
            int cardID = 0;
            if (dgv_CreditCards.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kredi kartını seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cardID = Convert.ToInt32(dgv_CreditCards.CurrentRow.Cells["ID"].Value);

            var creditCard = kocBankContext.CreditCards.FirstOrDefault(x => x.ID == cardID);
            if (creditCard != null) {

                creditCard.IsActive = false;

                kocBankContext.CreditCards.Update(creditCard);
                kocBankContext.SaveChanges();
                helper.DgvCreditCardRefresher(takencustomer.ID, dgv_CreditCards);
            }
        }
    }
}
