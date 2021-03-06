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
    
    public partial class ExternalTrainerDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExternalTrainerDetail()
        {
            this.TrainerDetails = new HashSet<TrainerDetail>();
            this.TrainingEmployeeLogs = new HashSet<TrainingEmployeeLog>();
        }
    
        public int ExternalTrainerId { get; set; }
        public string ExternalTrainerName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string CompanyName { get; set; }
        public string Website { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainerDetail> TrainerDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingEmployeeLog> TrainingEmployeeLogs { get; set; }
    }
}
