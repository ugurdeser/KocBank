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
        public string CVV { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
