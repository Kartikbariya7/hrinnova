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
    
    public partial class EmailData
    {
        public long ID { get; set; }
        public long PickupID { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public string FromName { get; set; }
        public string From { get; set; }
        public string ToName { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public byte EmailFormat { get; set; }
        public byte Priority { get; set; }
        public string Body { get; set; }
        public string AttachmentFileStreamID { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
    
        public virtual Pickup Pickup { get; set; }
    }
}
