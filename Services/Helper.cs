using KocBank.Context;
using KocBank.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Services
{
    public class Helper
    {
        KocBankContext kocBankContext = new KocBankContext();
        BankBranch bankBranch = new BankBranch();
        BankInformation bankInformation = new BankInformation();
        public byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
            return null;
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }

            return null;

        }

        public string CreateAccountNumber(Customer customer)
        {
            //Banka Kodu (4 basamak) + Şube Kodu (4 basamak) + Müşteri No (8 basamak) + Kontrol Numarası (2 basamak)

            Random random = new Random();
            int bankID = 1;
            int branchID = 2;

            bankBranch = kocBankContext.BankBranches.FirstOrDefault(x => x.ID == branchID);
            bankInformation = kocBankContext.BankInformation.FirstOrDefault(x => x.ID == bankID);


            string bankCode = bankInformation.BankCode.ToString();
            string branchCode = bankBranch.BranchCode.ToString();
            string customerNo = customer.CustomerBankNumber.ToString();
            string controlNumber = random.Next(10, 99).ToString();

            return bankCode + branchCode + customerNo + controlNumber;
        }

        public string CreateIBAN(string AccountNumber)
        {
            //TR + 2 haneli kontrol numarası + 4 haneli banka kodu + 4 haneli şube kodu + 8 haneli müşteri numarası + 2 haneli kontrol numarası

            Random random = new Random();

            string tr = "TR";
            string controlNumber = random.Next(10, 99).ToString();

            return tr + controlNumber + AccountNumber;
        }

        internal string CustomerBankNumber()
        {
            //Müşteri Numarası (8 basamak)

            Random random = new Random();

            return random.Next(10000000, 99999999).ToString();
        }

        public void DgvAccountRefresher(int customerID, DataGridView dgw)
        {
            dgw.DataSource = null;

            DataTable dt = new DataTable();

            List<Account> usersAccount = kocBankContext.Accounts.Where(x => x.CustomerID == customerID && x.IsActive == true).ToList();

            dt.Columns.Add("ID");
            dt.Columns.Add("Hesap Türü");
            dt.Columns.Add("Cinsi");
            dt.Columns.Add("Faiz Oranı");
            dt.Columns.Add("Komisyon Oranı");
            dt.Columns.Add("Hesap Numarasi");
            dt.Columns.Add("IBAN");
            dt.Columns.Add("Açılış Tarihi");
            dt.Columns.Add("Hesap Detayı");


            foreach (var item in usersAccount)
            {
                dt.NewRow();
                dt.Rows.Add(item.ID, item.AccountType.Name, item.Currency.Name, item.InterestRate, item.CommissionRate, item.AccountNumber, item.IBAN, item.CreatedDate.ToShortDateString(), typeof(DataGridViewButtonColumn));

            }
            dgw.DataSource = dt;
            dgw.Columns["ID"].Width = 30;
            dgw.Columns["Faiz Oranı"].Width = 50;
            dgw.Columns["Cinsi"].Width = 50;
            dgw.Columns["Komisyon Oranı"].Width = 50;
            dgw.Columns["Açılış Tarihi"].Width = 100;

        }

        public void DgvAcountDetailRefresher(int accountID, DataGridView dgw)
        {
            dgw.DataSource = null;

            DataTable dt = new DataTable();

            List<AccountTransaction> accountTransactions = kocBankContext.AccountTransactions.Where(x => x.AccountID == accountID).ToList();

            dt.Columns.Add("ID");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("İşlem Tipi");
            dt.Columns.Add("Miktar");


            foreach (var item in accountTransactions)
            {
                dt.NewRow();
                dt.Rows.Add(item.ID, item.CreatedDate, item.TransactionType.Name, item.Amount);
            }
            dgw.DataSource = dt;

        }
    }
}
