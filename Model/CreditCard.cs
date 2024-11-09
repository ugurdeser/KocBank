using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Model
{
    [Table("CreditCard")]
    public class CreditCard
    {
        [Key]
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpirationDate { get; set; }
        //Son odeme tarihi
        public DateTime LastPaymentDay { get; set; }
        //Odeme gunu
        public DateTime PaymentDueDate { get; set; }
        public string CVV { get; set; }
        public int Limit { get; set; }
        public int Balance { get; set; }
        public int CardTypeID { get; set; }
        public virtual CardType CardType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
