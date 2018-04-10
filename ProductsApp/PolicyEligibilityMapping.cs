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
    
    public partial class PolicyEligibilityMapping
    {
        public int PolicyEligibilityMappingID { get; set; }
        public int PolicyID { get; set; }
        public byte EligibilityTypeID { get; set; }
        public Nullable<decimal> EligibilityLimit { get; set; }
        public Nullable<bool> isHoliday { get; set; }
        public Nullable<bool> isWeekOff { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDt { get; set; }
        public Nullable<byte> StatusID { get; set; }
    
        public virtual EligibilityType EligibilityType { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual Status Status { get; set; }
    }
}
