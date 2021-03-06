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
    
    public partial class ProjectSprint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectSprint()
        {
            this.dataentries = new HashSet<dataentry>();
            this.tblIterationHistories = new HashSet<tblIterationHistory>();
            this.tblNotifications = new HashSet<tblNotification>();
            this.tblTaskRemainingHourDetails = new HashSet<tblTaskRemainingHourDetail>();
            this.WBS = new HashSet<WB>();
        }
    
        public int SprintId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public Nullable<System.DateTime> PlannedStartDate { get; set; }
        public Nullable<System.DateTime> PlannedEndDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public bool IsDisabled { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> CompletedDate { get; set; }
        public Nullable<int> ReleaseID { get; set; }
        public Nullable<int> PercentageCompleted { get; set; }
        public Nullable<int> EstimatedHours { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dataentry> dataentries { get; set; }
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual PMSRelease PMSRelease { get; set; }
        public virtual project project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIterationHistory> tblIterationHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNotification> tblNotifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaskRemainingHourDetail> tblTaskRemainingHourDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WB> WBS { get; set; }
    }
}
