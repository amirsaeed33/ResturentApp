using ResturantApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class CashierViewModel
    {
        public List<Product> Products { get; set; }
        public int? Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public int? PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime BirthDate { get; set; }
        public bool ComputerLiterate { get; set; }



        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Cashier";
                return "NewCashier Cashier";
            }
        }
        public CashierViewModel()
        {
            Id = 0;
        }

        public CashierViewModel(Cashier cashier)
        {
            Id = cashier.Id;
            FullName = cashier.FullName;
            BirthDate = cashier.BirthDate;
            Gender = cashier.Gender;
            PhoneNumber = cashier.PhoneNumber;
            EmailAddress = cashier.EmailAddress;
            ComputerLiterate = cashier.ComputerLiterate;
        }

    }
}