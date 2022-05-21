using ResturantApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class CashierViewModel
    {
        public List<Product> Products { get; set; }
        public int? Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public string NameOfNextOfKin { get; set; }
        public string NextOfKinPhoneNumber { get; set; }
        public string NextOfKinRelation { get; set; }
        public string PermanentAddress { get; set; }
        public string LGA { get; set; }
        public string StateOfOrigin { get; set; }
        public string ContactAddress { get; set; }
        
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
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
            Photo = cashier.Photo;
            NameOfNextOfKin = cashier.NameOfNextOfKin;
            NextOfKinPhoneNumber = cashier.NextOfKinPhoneNumber;
            NextOfKinRelation = cashier.NextOfKinRelation;
            PermanentAddress = cashier.PermanentAddress;
            ContactAddress = cashier.ContactAddress;
            StateOfOrigin = cashier.StateOfOrigin;
            LGA = cashier.LGA;
            Position = cashier.Position;
            
        }

    }
}