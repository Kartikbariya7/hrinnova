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
    
    public partial class tblSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSchedule()
        {
            this.tblEmployeeSchedules = new HashSet<tblEmployeeSchedule>();
            this.tblScheduleTimes = new HashSet<tblScheduleTime>();
        }
    
        public int ScheduleID { get; set; }
        public string ScheduleName { get; set; }
        public string InTime { get; set; }
        public Nullable<bool> IsNightShift { get; set; }
        public string OutTime { get; set; }
        public string OutTimeTolerance { get; set; }
        public string Remarks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployeeSchedule> tblEmployeeSchedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblScheduleTime> tblScheduleTimes { get; set; }
    }
}
