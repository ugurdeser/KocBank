using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KocBank.Model
{
    [Table("AutoPaymentList")]
    public class AutoPaymentList
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int PaymentDay { get; set; }
        public bool IsActive { get; set; }
    }
}