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
    
    public partial class tblEvalutionFrequency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEvalutionFrequency()
        {
            this.tblKRAAssigns = new HashSet<tblKRAAssign>();
            this.tblKRAEVLPrdSettings = new HashSet<tblKRAEVLPrdSetting>();
        }
    
        public int EvalutionFrequencyId { get; set; }
        public string Frequency { get; set; }
        public int Month { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAAssign> tblKRAAssigns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKRAEVLPrdSetting> tblKRAEVLPrdSettings { get; set; }
    }
}
