using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Markert.Models
{
    public class DocumentType
    {
        [Key]
        [Display(Name = "Document Type")]
        public int DocumentTypeID { get; set; }
        [Display(Name = "Document")]
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}