using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Markert.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string ContacFirstName { get; set; }
        public string ContacLastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public virtual ICollection<SupplierProduct>  SupplierProducts { get; set; }
    }
}