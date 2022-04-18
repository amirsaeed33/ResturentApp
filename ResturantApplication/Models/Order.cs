using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public PaymentType PaymentType { get; set; }
        public byte PaymentTypeId { get; set; }
        public Cashier Cashier { get; set; }
        public byte CashierId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int FinalTotal { get; set; }

    }
}