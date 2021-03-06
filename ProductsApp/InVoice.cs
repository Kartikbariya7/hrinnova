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
    
    public partial class InVoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InVoice()
        {
            this.Receipts = new HashSet<Receipt>();
        }
    
        public int InvoiceID { get; set; }
        public int BAID { get; set; }
        public System.DateTime InVoiceDate { get; set; }
        public string InVoiceNumber { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Hours { get; set; }
        public Nullable<decimal> PerHourRate { get; set; }
        public string Amount { get; set; }
        public Nullable<short> NoOfReceipt { get; set; }
        public string OutStanding { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> Createdby { get; set; }
        public Nullable<int> Updatedby { get; set; }
        public string ReceiptData { get; set; }
    
        public virtual BusinessAgreement BusinessAgreement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
