using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public Items Items { get; set; }
        public byte ItemsId { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}