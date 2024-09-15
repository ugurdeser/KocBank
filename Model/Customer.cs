using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Model
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string CustomerBankNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string GovernmentID { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public virtual City City { get; set; }  
        public int CityID { get; set; }
        public string Email { get; set; }
        public byte[] CustomerPicture { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual List<Account> Accounts { get; set; }
        public virtual List<CreditCard> CreditCards { get; set; }

    }
}
