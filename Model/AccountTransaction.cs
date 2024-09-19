using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Model
{
    [Table("AccountTransaction")]
    public class AccountTransaction
    {
        [Key]
        public int ID { get; set; }
        public int AccountID { get; set; }
        public virtual Account Account { get; set; }
        public int TransactionTypeID { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
