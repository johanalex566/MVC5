using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Markert.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; }
        public float Stock { get; set; }
        public string Remarks { get; set; }
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
    }
}