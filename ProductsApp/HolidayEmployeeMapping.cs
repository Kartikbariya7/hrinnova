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
    
    public partial class HolidayEmployeeMapping
    {
        public int HolidayEmployeeMappingID { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<int> HolidayListMappingID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDt { get; set; }
        public Nullable<byte> StatusID { get; set; }
        public Nullable<System.DateTime> ObservingDate { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual HolidayListMapping HolidayListMapping { get; set; }
        public virtual Status Status { get; set; }
    }
}
