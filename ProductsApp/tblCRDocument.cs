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
    
    public partial class tblCRDocument
    {
        public int ID { get; set; }
        public int DocTypeID { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string DisplayName { get; set; }
        public int CRID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> ChangeRequestMilestoneID { get; set; }
    
        public virtual tblChangeRequestMaster tblChangeRequestMaster { get; set; }
        public virtual tblPINDocumentTypeMaster tblPINDocumentTypeMaster { get; set; }
    }
}
