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
    
    public partial class AttendanceReportDepartmentLookup
    {
        public int AttendanceReportDepartmentLookupId { get; set; }
        public int AttendanceReportParameterId { get; set; }
        public int DepartmentId { get; set; }
        public bool Deleted { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Updated_By { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual AttendanceReprotParameter AttendanceReprotParameter { get; set; }
        public virtual department department { get; set; }
    }
}
