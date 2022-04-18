using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public Order Order { get; set; }
        public byte OrderId { get; set; }
        public Items Items { get; set; }
        public byte ItemsId { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int Total { get; set; }
    }
}