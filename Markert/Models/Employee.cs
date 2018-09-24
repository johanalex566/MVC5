using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Markert.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Display(Name = "First nombre")]
        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {1} and {2} characters", MinimumLength = 3)]
        public string FirstName { get; set; }
        [Display(Name = "Last nombre")]
        [Required(ErrorMessage = "You must enter {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {1} and {2} characters", MinimumLength = 3)]
        public string LastName { get; set; }
        [Display(Name = "Salario")]
        [Required(ErrorMessage = "You must enter {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public Decimal Salary { get; set; }
        [Display(Name = "Bonus %")]
        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public float BonusPercent { get; set; }
        [Display(Name = "DateOfBirth")]
        [Required(ErrorMessage = "You must enter {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Url)]
        public string Url { get; set; }
        [Required(ErrorMessage = "You must enter {0}")]
        [NotMapped]
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

        [Display(Name = "Document Types")]
        public int DocumentTypeID { get; set; }

        public virtual DocumentType DocumentType { get; set; }
    }
}