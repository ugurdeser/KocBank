using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Model
{
    [Table("AccountType")]
    public class AccountType
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal InterestRate { get; set; }
        public decimal CommissionRate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
