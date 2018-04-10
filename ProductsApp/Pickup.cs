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
    
    public partial class Pickup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pickup()
        {
            this.EmailDatas = new HashSet<EmailData>();
        }
    
        public long ID { get; set; }
        public System.DateTime Stamp { get; set; }
        public byte Status { get; set; }
        public int Delay { get; set; }
        public byte Priority { get; set; }
        public byte Retry { get; set; }
        public Nullable<System.DateTime> NextRetryDate { get; set; }
        public byte DeliveryPreference { get; set; }
        public Nullable<byte> SentBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailData> EmailDatas { get; set; }
    }
}
