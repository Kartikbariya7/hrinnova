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
    
    public partial class tblTrainingWaiverMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTrainingWaiverMaster()
        {
            this.tblTrainingWaiverDetails = new HashSet<tblTrainingWaiverDetail>();
        }
    
        public int WaiverID { get; set; }
        public int TrainingID { get; set; }
        public int EmpID { get; set; }
        public bool IsLock { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public bool IsMailSendToHRD { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual employee employee2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTrainingWaiverDetail> tblTrainingWaiverDetails { get; set; }
        public virtual TrainingMaster TrainingMaster { get; set; }
    }
}
