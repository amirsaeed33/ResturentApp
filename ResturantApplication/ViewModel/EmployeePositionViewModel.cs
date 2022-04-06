using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantApplication.ViewModel
{
    public class EmployeePositionViewModel
    {
        public IEnumerable<EmployeePositionViewModel> EmployeePositions { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public int? PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public bool ComputerLiterate { get; set; }


    }
}