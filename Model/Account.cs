using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Model
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int ID { get; set; }
        public int BankBranchID { get; set; }
        public int BankBranchCode { get; set; }
        public int AccountTypeID { get; set; }
        public int CustomerID { get; set; }
        public int CurrencyID { get; set; }
        public decimal InterestRate { get; set; }
        public decimal CommissionRate { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
