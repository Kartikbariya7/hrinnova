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
    
    public partial class tblPINConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPINConfiguration()
        {
            this.tblPINConfigDetails = new HashSet<tblPINConfigDetail>();
        }
    
        public int ID { get; set; }
        public int PINAuthorityTypeID { get; set; }
        public Nullable<int> ApprovalTime { get; set; }
    
        public virtual tblPINAuthorityTypeMaster tblPINAuthorityTypeMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPINConfigDetail> tblPINConfigDetails { get; set; }
    }
}
