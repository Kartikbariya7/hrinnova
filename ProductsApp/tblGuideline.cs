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
    
    public partial class tblGuideline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGuideline()
        {
            this.tblKPIGuidelines = new HashSet<tblKPIGuideline>();
        }
    
        public int GuidelineID { get; set; }
        public Nullable<bool> IsGuidelineSameForAllFunctions { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> ModifiedByID { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public Nullable<bool> IsGuidelinesSameAtCoreLevel { get; set; }
        public Nullable<bool> IsGuidelinesSameAtLeadLevel { get; set; }
        public Nullable<bool> IsGuidelinesSameAtManageLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKPIGuideline> tblKPIGuidelines { get; set; }
    }
}