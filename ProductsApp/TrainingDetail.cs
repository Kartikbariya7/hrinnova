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
    
    public partial class TrainingDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrainingDetail()
        {
            this.tblTrainingWaiverDetails = new HashSet<tblTrainingWaiverDetail>();
            this.TraineeDetails = new HashSet<TraineeDetail>();
            this.TrainerDetails = new HashSet<TrainerDetail>();
            this.TrainingEmployeeLogs = new HashSet<TrainingEmployeeLog>();
            this.TrainingEquipmentDetails = new HashSet<TrainingEquipmentDetail>();
        }
    
        public long TrainingDetailId { get; set; }
        public int TrainingId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<long> ConferenceRoomId { get; set; }
        public Nullable<int> TrainingType { get; set; }
        public Nullable<double> Budget { get; set; }
        public Nullable<System.DateTime> PlannedStartDate { get; set; }
        public Nullable<System.DateTime> PlannedEndDate { get; set; }
        public string PlannedDuration { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public string ActualDuration { get; set; }
        public Nullable<int> Status { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public bool IsAttendanceTaken { get; set; }
        public string Venue { get; set; }
    
        public virtual ConferenceRoomMaster ConferenceRoomMaster { get; set; }
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual tblLocation tblLocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTrainingWaiverDetail> tblTrainingWaiverDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraineeDetail> TraineeDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainerDetail> TrainerDetails { get; set; }
        public virtual TrainingMaster TrainingMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingEmployeeLog> TrainingEmployeeLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingEquipmentDetail> TrainingEquipmentDetails { get; set; }
    }
}
