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
    
    public partial class tblSuggestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSuggestion()
        {
            this.WBS = new HashSet<WB>();
        }
    
        public int SuggestionId { get; set; }
        public int SuggestionType { get; set; }
        public string Description { get; set; }
        public bool IsBacklog { get; set; }
        public int CreatedId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedId { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public bool IsReply { get; set; }
        public string Attachment { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WB> WBS { get; set; }
    }
}
