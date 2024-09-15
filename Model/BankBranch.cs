using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KocBank.Model
{
    [Table("BankBranch")]
    public class BankBranch
    {
        [Key]
        public int ID { get; set; }
        public int BankID { get; set; }
        public string BankCode { get; set; }
        public virtual BankInformation BankInformation { get; set; }
        public int BranchCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public int CityID { get; set; }
        public virtual City City { get; set; }
        public int EmployeeID { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }


}
