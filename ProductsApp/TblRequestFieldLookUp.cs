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
    
    public partial class TblRequestFieldLookUp
    {
        public int ID { get; set; }
        public Nullable<int> RequestFieldMasterID { get; set; }
        public Nullable<int> ApprovalTypeID { get; set; }
        public Nullable<bool> IsMandatory { get; set; }
        public string RequiredMessage { get; set; }
        public string ValidationMessage { get; set; }
        public Nullable<bool> IsValidationRequired { get; set; }
        public string Caption { get; set; }
        public string DefaultValue { get; set; }
        public Nullable<bool> IsVisible { get; set; }
    
        public virtual ApprovalType ApprovalType { get; set; }
        public virtual TblRequestFieldMaster TblRequestFieldMaster { get; set; }
    }
}
