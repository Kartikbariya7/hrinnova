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
    
    public partial class Lookup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lookup()
        {
            this.EmployeeLanguageDetails = new HashSet<EmployeeLanguageDetail>();
            this.tblKPIFunctions = new HashSet<tblKPIFunction>();
            this.tblKPIGuidelines = new HashSet<tblKPIGuideline>();
            this.tblProjectStatusQuestions = new HashSet<tblProjectStatusQuestion>();
            this.tblTrainingFeedbackQuestions = new HashSet<tblTrainingFeedbackQuestion>();
            this.Templates = new HashSet<Template>();
            this.TrainingMasters = new HashSet<TrainingMaster>();
        }
    
        public int LookupID { get; set; }
        public int LookupTypeID { get; set; }
        public string Display { get; set; }
        public string Value { get; set; }
        public string Explanation { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int Created_By { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLanguageDetail> EmployeeLanguageDetails { get; set; }
        public virtual LookupType LookupType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKPIFunction> tblKPIFunctions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKPIGuideline> tblKPIGuidelines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProjectStatusQuestion> tblProjectStatusQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTrainingFeedbackQuestion> tblTrainingFeedbackQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Template> Templates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingMaster> TrainingMasters { get; set; }
    }
}
