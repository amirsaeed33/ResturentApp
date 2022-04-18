using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class TransactionViewModel
    {
        public IEnumerable<TransactionViewModel> TransactionViewModels { get; set; }
        public int TransactionId { get; set; }
        public byte ItemsId { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}