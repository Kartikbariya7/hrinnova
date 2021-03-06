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
    
    public partial class tblKRAMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKRAMaster()
        {
            this.tblKRAAssignDetails = new HashSet<tblKRAAssignDetail>();
            this.tblKRAEVLPRM_Relation = new HashSet<tblKRAEVLPRM_Relation>();
            this.tblKRAKPI_Relation = new HashSet<tblKRAKPI_Relation>();
            this.tblKRATempDetails = new HashSet<tblKRATempDetail>();
        }
    
        public int KRAId { get; set; }
        public int SkillId { get; set; }
        public string KRAName { get; set; }
        public string KRADescription { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public int CreatedByID { get; set; }
        public Nullable<int> UpdatedByID { get; set; }
        public string Notes { get; set; }
        public bool IsDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAAssignDetail> tblKRAAssignDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAEVLPRM_Relation> tblKRAEVLPRM_Relation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAKPI_Relation> tblKRAKPI_Relation { get; set; }
        public virtual tblKRASkill_Type tblKRASkill_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRATempDetail> tblKRATempDetails { get; set; }
    }
}
