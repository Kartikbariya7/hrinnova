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
    
    public partial class EmployeeAttachment
    {
        public int CertificateID { get; set; }
        public int empID { get; set; }
        public string Remarks_ { get; set; }
        public string CertificateLink { get; set; }
        public System.DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> AttachmentType { get; set; }
        public Nullable<bool> IsEmailSent { get; set; }
        public bool IsVisibleToEmployee { get; set; }
    
        public virtual DocumentType DocumentType { get; set; }
        public virtual employee employee { get; set; }
    }
}