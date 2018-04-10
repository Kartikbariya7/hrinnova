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
    
    public partial class tblKRATempDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKRATempDetail()
        {
            this.tblKRATempDetailEVLParams = new HashSet<tblKRATempDetailEVLParam>();
            this.tblKRATempDetailKPIs = new HashSet<tblKRATempDetailKPI>();
        }
    
        public int KRATempDetailId { get; set; }
        public int KRATemplateId { get; set; }
        public int KRAId { get; set; }
        public string Notes { get; set; }
        public int Weightage { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public int CreatedByID { get; set; }
        public Nullable<int> UpdatedByID { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual tblKRAMaster tblKRAMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRATempDetailEVLParam> tblKRATempDetailEVLParams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRATempDetailKPI> tblKRATempDetailKPIs { get; set; }
        public virtual tblKRATemplate tblKRATemplate { get; set; }
    }
}