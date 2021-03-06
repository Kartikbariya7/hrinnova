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
    
    public partial class PolicyWorkTimeMapping
    {
        public int PolicyWorkTimeMappingID { get; set; }
        public int PolicyID { get; set; }
        public byte CycleTypeID { get; set; }
        public byte ShiftTypeID { get; set; }
        public Nullable<decimal> DayMinNet { get; set; }
        public Nullable<decimal> DayMinGross { get; set; }
        public Nullable<decimal> HalfDayMinNet { get; set; }
        public Nullable<decimal> HalfDayMinGross { get; set; }
        public Nullable<decimal> DayMinReqHours { get; set; }
        public Nullable<decimal> MonthlyMinGross { get; set; }
        public Nullable<byte> GracePeriod { get; set; }
        public Nullable<byte> BreakLimit { get; set; }
        public Nullable<byte> BreakTimeLimit { get; set; }
        public Nullable<short> ExemptionLimit { get; set; }
        public Nullable<decimal> ExemptionTimeLimit { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDt { get; set; }
        public Nullable<byte> StatusID { get; set; }
        public Nullable<int> ExemptionTypeID { get; set; }
    
        public virtual CycleType CycleType { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual ShiftType ShiftType { get; set; }
        public virtual Status Status { get; set; }
    }
}
