using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class OrderDetailsViewModel
    {
        public IEnumerable<OrderDetailsViewModel> OrderDetailsViewModels { get; set; }
        public int OrderDetailsId { get; set; }
        public byte OrderId { get; set; }
        public byte ItemsId { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int Total { get; set; }
    }
}