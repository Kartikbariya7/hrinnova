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
    
    public partial class EmployeeLanguageDetailReplica
    {
        public int EmployeeLanguageDetailReplicaID { get; set; }
        public int EmployeeLanguageDetailD { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<int> Fluency { get; set; }
        public Nullable<bool> AbilityS { get; set; }
        public Nullable<bool> AbilityW { get; set; }
        public Nullable<bool> AbilityR { get; set; }
        public Nullable<bool> IsRecordDeleted { get; set; }
        public Nullable<byte> ProfileStatus { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
