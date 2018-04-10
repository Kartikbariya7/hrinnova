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
    
    public partial class tblAttendanceException
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAttendanceException()
        {
            this.EmployeeWorkingHoursTemps = new HashSet<EmployeeWorkingHoursTemp>();
            this.tblAttendanceExceptionDepartmentLookups = new HashSet<tblAttendanceExceptionDepartmentLookup>();
            this.tblAttendanceExceptionEmployeeLookups = new HashSet<tblAttendanceExceptionEmployeeLookup>();
        }
    
        public int AttendanceExceptionId { get; set; }
        public Nullable<System.DateTime> PrimaryDate { get; set; }
        public Nullable<System.DateTime> CompensateDate { get; set; }
        public Nullable<int> ExceptionTypeId { get; set; }
        public Nullable<int> ApplicableLevel { get; set; }
        public string ApplicableToLeaveOption { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> IsExceptionActive { get; set; }
        public int Created_By { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsMigrated { get; set; }
        public Nullable<bool> IsApplicableInARS { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeWorkingHoursTemp> EmployeeWorkingHoursTemps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAttendanceExceptionDepartmentLookup> tblAttendanceExceptionDepartmentLookups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAttendanceExceptionEmployeeLookup> tblAttendanceExceptionEmployeeLookups { get; set; }
    }
}