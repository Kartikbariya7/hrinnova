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
    
    public partial class EmployeeDomainLookupReplica
    {
        public int EmpDomainLookupReplicaId { get; set; }
        public int EmpId { get; set; }
        public int DomainId { get; set; }
        public Nullable<byte> ProfileStatus { get; set; }
        public bool IsRecordDeleted { get; set; }
        public bool IsNew { get; set; }
    
        public virtual domain domain { get; set; }
        public virtual employee employee { get; set; }
    }
}
