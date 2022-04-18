using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class OrderViewModel
    {
        public IEnumerable<OrderViewModel> OrderViewModels { get; set; }
        public int OrderId { get; set; }
        public byte PaymentTypeId { get; set; }
        public byte CashierId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int FinalTotal { get; set; }
    }
}