﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Markert.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        [Required(ErrorMessage = "You must enter {0}")]
        public string Name { get; set; }
        public string ContacFirstName { get; set; }
        public string ContacLastName { get; set; }
        [Required(ErrorMessage = "You must enter {0}")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Adress { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public virtual ICollection<SupplierProduct>  SupplierProducts { get; set; }
    }
}