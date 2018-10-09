using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Markert.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "You must enter {0}")]
        public string Name { get; set; }
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You must enter {0}")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Adress { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must enter {0}")]
        public string Document { get; set; }

        [Display(Name = "Document type")]
        public int DocumentTypeID { get; set; }
        public virtual DocumentType DocumentType { get; set; }

    }
}
