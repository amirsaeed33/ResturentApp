using ResturantApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class PaymentTypeViewModel
    {
        public IEnumerable<PaymentType> PaymentTypes { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }

              

        public PaymentTypeViewModel(Product product)
        {

        }

    }
}