//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeInOutTemp
    {
        public int EmployeeInOutID { get; set; }
        public int empID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<decimal> WorkingHours { get; set; }
        public Nullable<int> AttendanceType { get; set; }
        public Nullable<System.TimeSpan> WorkingHoursInTimeStamp { get; set; }
        public Nullable<int> TrainingId { get; set; }
        public bool IsPunchFromMobile { get; set; }
        public string InLatitude { get; set; }
        public string InLongitude { get; set; }
        public string OutLatitude { get; set; }
        public string OutLongitude { get; set; }
    
        public virtual employee employee { get; set; }
    }
}