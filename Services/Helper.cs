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
            KocBankContext kocBankContext = new KocBankContext();
            BankBranch bankBranch = new BankBranch();
            BankInformation bankInformation = new BankInformation();
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

        public string CustomerBankNumber()
        {
            //Müşteri Numarası (8 basamak)

            Random random = new Random();

            return random.Next(10000000, 99999999).ToString();
        }

        public void DgvAccountRefresher(int customerID, DataGridView dgw)
        {
            KocBankContext kocBankContext = new KocBankContext();

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


            foreach (var item in usersAccount)
            {
                dt.NewRow();
                dt.Rows.Add(item.ID, item.AccountType.Name, item.Currency.Name, item.InterestRate, item.CommissionRate, item.AccountNumber, item.IBAN, item.CreatedDate.ToShortDateString());

            }

            dgw.DataSource = dt;
            dgw.Columns["ID"].Width = 30;
            dgw.Columns["Faiz Oranı"].Width = 50;
            dgw.Columns["Cinsi"].Width = 50;
            dgw.Columns["Komisyon Oranı"].Width = 50;
            dgw.Columns["Açılış Tarihi"].Width = 100;

        }

        public void DgvAccountDepositAndWithdrawal(int customerID, DataGridView dgw)
        {
            KocBankContext kocBankContext = new KocBankContext();


            decimal tblance = 0;
            int accountID = 0;
            dgw.DataSource = null;
            DataTable dt = new DataTable();

            List<Account> usersAccount = kocBankContext.Accounts.Where(x => x.CustomerID == customerID && x.IsActive == true).ToList();

            foreach (var item in usersAccount)
            {
                accountID = item.ID;

                List<AccountTransaction> accountTransactions = kocBankContext.AccountTransactions.Where(x => x.AccountID == accountID).ToList();

                tblance = accountTransactions.Where(x => x.TransactionTypeID == 1).Sum(x => x.Amount) - accountTransactions.Where(x => x.TransactionTypeID == 2).Sum(x => x.Amount);

                item.Balance = tblance;

            }

            dt.Columns.Add("ID");
            dt.Columns.Add("Hesap Türü");
            dt.Columns.Add("Cinsi");
            dt.Columns.Add("Hesap Numarasi");
            dt.Columns.Add("Bakiye");
            dt.Columns.Add("Açılış Tarihi");



            foreach (var item in usersAccount)
            {
                dt.NewRow();
                dt.Rows.Add(item.ID, item.AccountType.Name, item.Currency.Name, item.AccountNumber, item.Balance, item.CreatedDate.ToShortDateString());

            }

            dgw.DataSource = dt;
            dgw.Columns["ID"].Width = 30;
            dgw.Columns["Cinsi"].Width = 50;
            dgw.Columns["Açılış Tarihi"].Width = 100;

        }

        public void DgvAcountDetailRefresher(int accountID, DataGridView dgw)
        {
            KocBankContext kocBankContext = new KocBankContext();

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
                dt.Rows.Add(item.ID, item.CreatedDate.ToShortDateString(), item.TransactionType.Name, item.Amount);
            }
            dgw.DataSource = dt;
            dgw.Columns["ID"].Width = 30;
            dgw.Columns["Tarih"].Width = 50;
            dgw.Columns["İşlem Tipi"].Width = 150;
            dgw.Columns["Miktar"].Width = 200;

        }

        public void DgvCreditCardRefresher(int ID, DataGridView dgv_CreditCards)
        {

            dgv_CreditCards.DataSource = null;

            KocBankContext kocBankContext = new KocBankContext();

            List<CreditCard> CreditCard = kocBankContext.CreditCards.Where(x => x.CustomerID == ID).ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Kart Numarası");
            dt.Columns.Add("Son Kullanma Tarihi");
            dt.Columns.Add("Limit");
            dt.Columns.Add("Borç");
            dt.Columns.Add("Kart Tipi");

            foreach (var item in CreditCard)
            {
                dt.NewRow();
                dt.Rows.Add(item.ID, item.CardNumber, item.ExpirationDate, item.Limit, item.Balance, item.CardType.Name);
            }

            dgv_CreditCards.DataSource = dt;
            dgv_CreditCards.Columns["ID"].Width = 30;
            dgv_CreditCards.Columns["Kart Numarası"].Width = 100;
            dgv_CreditCards.Columns["Son Kullanma Tarihi"].Width = 100;
            dgv_CreditCards.Columns["Limit"].Width = 50;
            dgv_CreditCards.Columns["Borç"].Width = 50;
            dgv_CreditCards.Columns["Kart Tipi"].Width = 100;



        }

        public string CardNumberGenerator()
        {
            string cardNumber = "";

            Random random = new Random();

            for (int i = 0; i < 16; i++)
            {
                cardNumber += random.Next(0, 9).ToString();
            }

            return cardNumber;
        }

        public string CVVGenerator()
        {
            string cardCVV = "";

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                cardCVV += random.Next(0, 9).ToString();
            }

            return cardCVV;
        }

        public string GovernmentIDGenerator()
        {
            string governmentID = "";

            Random random = new Random();
            for (int i = 0; i < 11; i++)
            {
                governmentID += random.Next(0, 9).ToString();
            }

            return governmentID;
        }

        public string PhoneNumberGenerator()
        {
            string phoneNumber = "";

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                phoneNumber += random.Next(0, 9).ToString();
            }

            return phoneNumber;
        }


        //Burasi Geliştirilecek Eksikler Var
        //Bu program her acildiginda tarihleri kontrol edecek
        public void PaymentDueDateLooker()
        {
            //KocBankContext kocBankContext = new KocBankContext();
            //List<CreditCard> creditCards = new List<CreditCard>();
            //List<Account> accounts = new List<Account>();


            //creditCards = kocBankContext.CreditCards.Where(x => x.IsActive == true).ToList();
            
            //if (kocBankContext.CreditCards.Count() == 0 || kocBankContext.Accounts.Count() == 0)
            //{
            //    return;

            //}
            //accounts = kocBankContext.Accounts.Where(x => x.AccountTypeID == 3 && x.IsActive == true).ToList();

            //foreach (var item in creditCards)
            //{
            //    if (item.PaymentDueDate < DateTime.Now)
            //    {
            //        item.PaymentDueDate = item.PaymentDueDate.AddMonths(1);
            //    }
            //}

            //foreach (var item in accounts)
            //{
            //    if (item.PaymentDueDate < DateTime.Now)
            //    {
            //        if (DateTime.Now - item.PaymentDueDate >= TimeSpan.FromDays(30) && DateTime.Now - item.PaymentDueDate <= TimeSpan.FromDays(60))
            //        {
            //            item.PaymentDueDate = item.PaymentDueDate.AddMonths(1);
            //        }
            //        else
            //        {
            //            int days = (DateTime.Now - item.PaymentDueDate).Days;
            //            int lookAt = days / 30 + 1;

            //            item.PaymentDueDate = item.PaymentDueDate.AddMonths(lookAt);
            //        }
            //    }
            //}

            //foreach (var item in creditCards)
            //{
            //    if (item.PaymentDueDate < DateTime.Now)
            //    {
            //        if (DateTime.Now - item.PaymentDueDate >= TimeSpan.FromDays(30) && DateTime.Now - item.PaymentDueDate <= TimeSpan.FromDays(60))
            //        {
            //            item.PaymentDueDate = item.PaymentDueDate.AddMonths(1);
            //        }
            //        else
            //        {
            //            int days = (DateTime.Now - item.PaymentDueDate).Days;
            //            int lookAt = days / 30;

            //            item.PaymentDueDate = item.PaymentDueDate.AddMonths(lookAt);
            //        }
            //    }
            //}

            //kocBankContext.Accounts.UpdateRange(accounts);
            //kocBankContext.CreditCards.UpdateRange(creditCards);
            //kocBankContext.SaveChanges();


        }


    }
}
