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
    
    public partial class EmployeeVisaDetailReplica
    {
        public int EmployeeVisaDetailReplicaID { get; set; }
        public int EmployeeVisaDetail { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> VisaType { get; set; }
        public Nullable<System.DateTime> VisaExpiryDate { get; set; }
        public Nullable<System.DateTime> VisaIssueDate { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<bool> IsDeletedRecord { get; set; }
        public Nullable<byte> ProfileStatus { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual employee employee { get; set; }
    }
}
