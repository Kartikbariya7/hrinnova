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
    
    public partial class tblSkillRating
    {
        public int SkillRatingId { get; set; }
        public int SkillId { get; set; }
        public Nullable<decimal> SelfRating { get; set; }
        public string SelfRemarks { get; set; }
        public Nullable<decimal> SupervisorRating { get; set; }
        public string SupervisorRemarks { get; set; }
        public int EmpId { get; set; }
        public int Stage { get; set; }
        public Nullable<int> VerifiedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual technology technology { get; set; }
    }
}
