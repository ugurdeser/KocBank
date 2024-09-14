using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Model
{
    [Table("MoneyTransfer")]
    public class MoneyTransfer
    {
        [Key]
        public int ID { get; set; }
        public int CurrencyID { get; set; }
        public int TransferTypeID { get; set; }
        public int SenderAccountNumber { get; set; }
        public int ReceiverAccountNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
