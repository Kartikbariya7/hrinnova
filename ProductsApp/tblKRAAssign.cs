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
    
    public partial class tblKRAAssign
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKRAAssign()
        {
            this.tblKRAAssignDevelopmentPlans = new HashSet<tblKRAAssignDevelopmentPlan>();
            this.tblKRAAssignEvaluationDates = new HashSet<tblKRAAssignEvaluationDate>();
            this.tblKRAAssignDetails = new HashSet<tblKRAAssignDetail>();
            this.tblKRACommentTransections = new HashSet<tblKRACommentTransection>();
        }
    
        public int KRAAssignId { get; set; }
        public int EvalutionFrequencyId { get; set; }
        public int empID { get; set; }
        public int RoleId { get; set; }
        public int KRAStatusId { get; set; }
        public System.DateTime FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public int CreatedById { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> ApprovedByManagerId { get; set; }
        public Nullable<int> ApprovedBySupervisorId { get; set; }
        public Nullable<System.DateTime> ApprovedByManagerDate { get; set; }
        public Nullable<System.DateTime> ApprovedBySupervisorDate { get; set; }
        public string DevelopementNotes { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool isApprovalCompleted_LevelOne { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual employee employee2 { get; set; }
        public virtual role role { get; set; }
        public virtual tblEvalutionFrequency tblEvalutionFrequency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAAssignDevelopmentPlan> tblKRAAssignDevelopmentPlans { get; set; }
        public virtual tblKRAStatu tblKRAStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAAssignEvaluationDate> tblKRAAssignEvaluationDates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAAssignDetail> tblKRAAssignDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRACommentTransection> tblKRACommentTransections { get; set; }
    }
}