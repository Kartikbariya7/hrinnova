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
    
    public partial class tblLink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblLink()
        {
            this.tblLinks1 = new HashSet<tblLink>();
        }
    
        public int LinkID { get; set; }
        public string LinkTypeId { get; set; }
        public string LinkText { get; set; }
        public string LinkURL { get; set; }
        public Nullable<int> LinkParentID { get; set; }
        public string LinkParentName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int Created_By { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string FilePath { get; set; }
        public string FileExtension { get; set; }
        public string LinkIcon { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLink> tblLinks1 { get; set; }
        public virtual tblLink tblLink1 { get; set; }
    }
}