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
    
    public partial class tblProjectInitiationLookup
    {
        public int tblProjectInitiationLookupId { get; set; }
        public int ProjectInitiationId { get; set; }
        public Nullable<int> Comment_By { get; set; }
        public System.DateTime Comment_On { get; set; }
        public string Comment_Description { get; set; }
        public string AttachDocument { get; set; }
        public Nullable<int> ReferenceNo { get; set; }
        public string ActivityType { get; set; }
        public string CommentSummary { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual projectinitiation projectinitiation { get; set; }
    }
}
