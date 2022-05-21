using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResturantApplication.Models
{
    public class Cashier
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        [Display(Name = "Date of Birth ")]
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
        public bool ComputerLiterate { get; set; }
        public bool IsDeleted { get; internal set; }


        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

    }
}