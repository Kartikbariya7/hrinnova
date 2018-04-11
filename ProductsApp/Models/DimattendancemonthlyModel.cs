using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class DimattendancemonthlyModel
    {

        public int EmpID { get; set; }

        public string PayrollMonth { get; set; }
        
        public int CalenderDays { get; set; }
        
        public int WorkingDays { get; set; }
        
        public int FullDay { get; set; }
        
        public int HalfDay { get; set; }
        
        public decimal Absent { get; set; }
        
        public int LeavesFullDay { get; set; }
        
        public decimal LeavesHalfDay { get; set; }
        
        public int SandwichLeave { get; set; }
        
        public string TotalGrossHours { get; set; }
        
        public string TotalNetHours { get; set; }
        
        public string TotalTimesheetHours { get; set; }
        
        public string TotalWOHHours { get; set; }
        
        public string TotalBreakHours { get; set; }
        
        public string AvgGrossHours { get; set; }
        
        public string AvgNetHours { get; set; }
        
        public string AvgTimesheetHours { get; set; }
        
        public int PenaltyCount { get; set; }
        
        public decimal LateComing { get; set; }
        
        public decimal EarlyLeaving { get; set; }
        
        public int MissPunch { get; set; }

        
        public int WFHRequest { get; set; }
        
        public int WOHRequest { get; set; }
        
        public int TOURRequest { get; set; }
        
        public decimal LOPRequest { get; set; }
        
        public decimal LOP_Absent { get; set; }
        
        public decimal LOPPenalty { get; set; }
        
        public decimal WOHTimeSheetHrs { get; set; }
        
        public decimal WeekOff { get; set; }
        
        public decimal PresentDays { get; set; }

    }
}