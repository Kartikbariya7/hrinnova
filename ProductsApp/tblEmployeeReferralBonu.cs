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
    
    public partial class tblEmployeeReferralBonu
    {
        public int EmpReferralBonusId { get; set; }
        public int EmpId { get; set; }
        public int ReferralEmpId { get; set; }
        public string Amount { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public bool IsPaid { get; set; }
        public System.DateTime CreateOn { get; set; }
        public int CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual employee employee2 { get; set; }
        public virtual employee employee3 { get; set; }
    }
}
