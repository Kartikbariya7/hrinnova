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
    
    public partial class tblAttendanceExceptionDepartmentLookup
    {
        public int AttendanceExceptionDepartmentLookupId { get; set; }
        public Nullable<int> ExceptionId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public int Created_By { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<bool> IsInclude { get; set; }
    
        public virtual department department { get; set; }
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual tblAttendanceException tblAttendanceException { get; set; }
    }
}
