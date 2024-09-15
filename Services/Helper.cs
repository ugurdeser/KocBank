using KocBank.Context;
using KocBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Services
{
    public class Helper
    {
        KocBankContext kocBankContext = new KocBankContext();
        public byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public string CreateAccountNumber(Customer customer)
        {
            //Banka Kodu (4 basamak) + Şube Kodu (4 basamak) + Müşteri No (8 basamak) + Kontrol Numarası (2 basamak)

            Random random = new Random();

            string bankCode = "1234";
            string branchCode = "5678";
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
    }
}
