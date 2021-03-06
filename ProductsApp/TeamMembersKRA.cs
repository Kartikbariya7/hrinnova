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
    
    public partial class TeamMembersKRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TeamMembersKRA()
        {
            this.EvaluationNotes = new HashSet<EvaluationNote>();
            this.tblKpiNotes = new HashSet<tblKpiNote>();
        }
    
        public int TeamMemberKRAId { get; set; }
        public int TeamMembersID { get; set; }
        public Nullable<int> KpiFunctionID { get; set; }
        public string KPIName { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int Status { get; set; }
        public Nullable<bool> TargetType { get; set; }
        public string TargetValue { get; set; }
        public string TargetNotes { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EvaluationNote> EvaluationNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKpiNote> tblKpiNotes { get; set; }
    }
}
