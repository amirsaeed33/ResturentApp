using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturantApplication.Models
{
    public class Items
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter the Item Name")]
        [StringLength(100)]
        [Display(Name = "Product Name")]
        public string Names { get; set; }

        [Required(ErrorMessage = "Please Enter the Item Price")]
        [Display(Name ="Item Price")]
        public int ItemPrice { get; set; }

        [Required(ErrorMessage = "Please Enter the Item Quantity")]
        [Display(Name = "Alert Quantity")]
        public int MinQty { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}