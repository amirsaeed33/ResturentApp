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
        public string Position { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool ComputerLiterate { get; set; }
        public bool IsDeleted { get; internal set; }

    }
}