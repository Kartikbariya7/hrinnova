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
    
    public partial class tblProfileRejectionHistory
    {
        public int ProfleRejectionID { get; set; }
        public int EmpID { get; set; }
        public string RejectionReason { get; set; }
        public Nullable<int> Created_by { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> Updateted_by { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public bool Isdeleted { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual employee employee2 { get; set; }
    }
}
