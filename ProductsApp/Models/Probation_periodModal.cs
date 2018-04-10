using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Probation_periodModal
    {
        public int empID { get; set; }
        public int ProbationPeriod { get; set; }
        public DateTime JoinDate { get; set; }
        public int Experience { get; set; }
        public String empCode { get; set; }

        public string bloodGroup { get; set; }

        public string passportNumber { get; set; }

        public int incrementperiod { get; set; }
       
        public int DepartmentID { get; set; }
        // public Probation_periodModal ResponseJson { get; set; }
    }
}