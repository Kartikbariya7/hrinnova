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
    
    public partial class tblPageTrackingSummary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPageTrackingSummary()
        {
            this.tblVisitedPageDetails = new HashSet<tblVisitedPageDetail>();
        }
    
        public int VisitedPageID { get; set; }
        public int PageTrackerID { get; set; }
        public Nullable<int> VisitedPageCount { get; set; }
        public Nullable<System.TimeSpan> TotalElapsedTime { get; set; }
    
        public virtual tblPageTracker tblPageTracker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVisitedPageDetail> tblVisitedPageDetails { get; set; }
    }
}
