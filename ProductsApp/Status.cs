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
    
    public partial class Status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Status()
        {
            this.AccumActionTypes = new HashSet<AccumActionType>();
            this.CycleTypes = new HashSet<CycleType>();
            this.EligibilityTypes = new HashSet<EligibilityType>();
            this.EmployeeEncashMasters = new HashSet<EmployeeEncashMaster>();
            this.EmployeeLeaveMasters = new HashSet<EmployeeLeaveMaster>();
            this.EmployeeLeaveTransactions = new HashSet<EmployeeLeaveTransaction>();
            this.ExtentTypes = new HashSet<ExtentType>();
            this.Holidays = new HashSet<Holiday>();
            this.HolidayEmployeeMappings = new HashSet<HolidayEmployeeMapping>();
            this.HolidayLists = new HashSet<HolidayList>();
            this.HolidayListMappings = new HashSet<HolidayListMapping>();
            this.HolidayMappings = new HashSet<HolidayMapping>();
            this.LeaveAcceptTypes = new HashSet<LeaveAcceptType>();
            this.LeaveCategories = new HashSet<LeaveCategory>();
            this.Penalties = new HashSet<Penalty>();
            this.PenaltyConfigs = new HashSet<PenaltyConfig>();
            this.PenaltyConfigTypes = new HashSet<PenaltyConfigType>();
            this.PenaltyEmployeeMappings = new HashSet<PenaltyEmployeeMapping>();
            this.PenaltyTypes = new HashSet<PenaltyType>();
            this.PMSEvents = new HashSet<PMSEvent>();
            this.PMSEventTypes = new HashSet<PMSEventType>();
            this.PMSReleases = new HashSet<PMSRelease>();
            this.Policies = new HashSet<Policy>();
            this.PolicyEligibilityMappings = new HashSet<PolicyEligibilityMapping>();
            this.PolicyLeaveMappings = new HashSet<PolicyLeaveMapping>();
            this.PolicyShiftMappings = new HashSet<PolicyShiftMapping>();
            this.PolicyWorkTimeMappings = new HashSet<PolicyWorkTimeMapping>();
            this.PolicyWorkWeekMappings = new HashSet<PolicyWorkWeekMapping>();
            this.ProjectConfigMappings = new HashSet<ProjectConfigMapping>();
            this.ProjectConfigTypes = new HashSet<ProjectConfigType>();
            this.SandwichLeaveTypes = new HashSet<SandwichLeaveType>();
            this.Shifts = new HashSet<Shift>();
            this.ShiftTypes = new HashSet<ShiftType>();
            this.WeekDayNames = new HashSet<WeekDayName>();
            this.WorkWeekTypes = new HashSet<WorkWeekType>();
        }
    
        public byte StatusID { get; set; }
        public string LkpName { get; set; }
        public string LkpCode { get; set; }
        public string Lkpdesc { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccumActionType> AccumActionTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CycleType> CycleTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EligibilityType> EligibilityTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeEncashMaster> EmployeeEncashMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLeaveMaster> EmployeeLeaveMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLeaveTransaction> EmployeeLeaveTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtentType> ExtentTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Holiday> Holidays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HolidayEmployeeMapping> HolidayEmployeeMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HolidayList> HolidayLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HolidayListMapping> HolidayListMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HolidayMapping> HolidayMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveAcceptType> LeaveAcceptTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveCategory> LeaveCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Penalty> Penalties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PenaltyConfig> PenaltyConfigs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PenaltyConfigType> PenaltyConfigTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PenaltyEmployeeMapping> PenaltyEmployeeMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PenaltyType> PenaltyTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMSEvent> PMSEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMSEventType> PMSEventTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMSRelease> PMSReleases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policy> Policies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyEligibilityMapping> PolicyEligibilityMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyLeaveMapping> PolicyLeaveMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyShiftMapping> PolicyShiftMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyWorkTimeMapping> PolicyWorkTimeMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolicyWorkWeekMapping> PolicyWorkWeekMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectConfigMapping> ProjectConfigMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectConfigType> ProjectConfigTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SandwichLeaveType> SandwichLeaveTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shift> Shifts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftType> ShiftTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeekDayName> WeekDayNames { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkWeekType> WorkWeekTypes { get; set; }
    }
}