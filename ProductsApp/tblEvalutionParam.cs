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
    
    public partial class tblEvalutionParam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEvalutionParam()
        {
            this.tblKRAEVLPRM_Relation = new HashSet<tblKRAEVLPRM_Relation>();
            this.tblKRAAssignDetailEVlParams = new HashSet<tblKRAAssignDetailEVlParam>();
            this.tblKRATempDetailEVLParams = new HashSet<tblKRATempDetailEVLParam>();
        }
    
        public int EvalutionParamId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public int CreatedById { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAEVLPRM_Relation> tblKRAEVLPRM_Relation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAAssignDetailEVlParam> tblKRAAssignDetailEVlParams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRATempDetailEVLParam> tblKRATempDetailEVLParams { get; set; }
    }
}
