using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResturantApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemsId { get; set; }
        [ForeignKey("ItemsId")]
        public Items Items { get; set; }
       
        public int PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }
      
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public int CashierId { get; set; }
        [ForeignKey("CashierId")]
        public Cashier Cashier { get; set; }
        
       

    }
}