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
    
    public partial class tblJustification
    {
        public int JustificationID { get; set; }
        public string JustificationKey { get; set; }
        public string JustificationName { get; set; }
        public System.DateTime JustificationCreatedDate { get; set; }
        public int JustificationCreatedBy { get; set; }
        public Nullable<System.DateTime> JustificationModifiedDate { get; set; }
        public Nullable<int> JustificationModifiedBy { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
    }
}
