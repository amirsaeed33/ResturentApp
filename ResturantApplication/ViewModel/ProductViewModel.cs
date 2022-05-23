using ResturantApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class ProductViewModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public byte? ItemsId { get; set; }
        public byte? PaymentTypeId { get; set; }
        public byte? CustomerId { get; set; }
        public int? Discount { get; set; }
        [Required]
        public int? Quantity { get; set; }
        public int? Total { get; set; }
        public IEnumerable<Items> Items { get; set; }
        public IEnumerable<PaymentType> PaymentTypes { get; set; }
        public IEnumerable<Cashier> Cashiers { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<OrderDetails> OrderDetails { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }



    }
}