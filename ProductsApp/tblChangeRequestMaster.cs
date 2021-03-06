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
    
    public partial class tblChangeRequestMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblChangeRequestMaster()
        {
            this.ChangeRequestPaymentMilestones = new HashSet<ChangeRequestPaymentMilestone>();
            this.tblCRDocuments = new HashSet<tblCRDocument>();
        }
    
        public int ID { get; set; }
        public string CRNumber { get; set; }
        public int ProjectInitiationId { get; set; }
        public int EstimateHours { get; set; }
        public Nullable<int> PriorityID { get; set; }
        public Nullable<int> LevelID { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> HourlyRate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<bool> ClientAcceptance { get; set; }
        public Nullable<decimal> ClientAcceptancePerctange { get; set; }
        public Nullable<bool> CompanyAcceptance { get; set; }
        public Nullable<int> PMOApprovalID { get; set; }
        public Nullable<int> SupervisorApprovalID { get; set; }
        public Nullable<int> PMOApprovalStatus { get; set; }
        public string CRStatus { get; set; }
        public Nullable<int> SupervisorStatus { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangeRequestPaymentMilestone> ChangeRequestPaymentMilestones { get; set; }
        public virtual projectinitiation projectinitiation { get; set; }
        public virtual tblPINLevelMaster tblPINLevelMaster { get; set; }
        public virtual tblPINPriorityMaster tblPINPriorityMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCRDocument> tblCRDocuments { get; set; }
    }
}
