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
    
    public partial class ApprovalType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApprovalType()
        {
            this.TblRequestFieldLookUps = new HashSet<TblRequestFieldLookUp>();
            this.timeoffrequests = new HashSet<timeoffrequest>();
            this.timeoffrequest_temp = new HashSet<timeoffrequest_temp>();
            this.TimeOffRequestClones = new HashSet<TimeOffRequestClone>();
        }
    
        public int ApprovalTypeId { get; set; }
        public string ApprovalType1 { get; set; }
        public bool IsApprovalRequired { get; set; }
        public Nullable<int> Deleted { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Value { get; set; }
        public Nullable<bool> IsHrApprovalRequired { get; set; }
        public Nullable<bool> IsProjectCodeRequired { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> RequestCategory { get; set; }
        public Nullable<bool> IsAffactOnAttendance { get; set; }
        public Nullable<bool> IsFullDayMandatory { get; set; }
        public Nullable<bool> IsTimeRequired { get; set; }
        public Nullable<bool> IsContactNoRequired { get; set; }
        public Nullable<bool> IsAddressRequired { get; set; }
        public Nullable<bool> IsTimeSheetEntryMandatory { get; set; }
        public string HREmail { get; set; }
        public Nullable<short> LeaveCategoryID { get; set; }
        public string Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblRequestFieldLookUp> TblRequestFieldLookUps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<timeoffrequest> timeoffrequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<timeoffrequest_temp> timeoffrequest_temp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeOffRequestClone> TimeOffRequestClones { get; set; }
    }
}
