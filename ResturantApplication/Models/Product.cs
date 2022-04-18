using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Items Items { get; set; }
        public byte ItemsId { get; set; }
        public PaymentType PaymentType { get; set; }
        public byte PaymentTypeId { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public Cashier Cashier { get; set; }
        public byte CashierId { get; set; }


    }
}