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
    
    public partial class tblKRADevelopmentPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKRADevelopmentPlan()
        {
            this.tblKRAAssignDevelopmentPlans = new HashSet<tblKRAAssignDevelopmentPlan>();
        }
    
        public int DevelopmentPlanId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Competence { get; set; }
        public int CreatedByID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> KRAId { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public int Status { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<int> DevelopmentTypeId { get; set; }
    
        public virtual employee employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAAssignDevelopmentPlan> tblKRAAssignDevelopmentPlans { get; set; }
        public virtual tblKRADevelopmentType tblKRADevelopmentType { get; set; }
    }
}
