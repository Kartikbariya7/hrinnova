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
    
    public partial class ScheduleJobSetting
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public System.DateTime LastExecutedDate { get; set; }
        public string LastExecutedStatus { get; set; }
        public bool IsExecute { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string CurrentStatus { get; set; }
        public Nullable<bool> OnlySendNotification { get; set; }
        public bool IsNotificationapplicable { get; set; }
        public Nullable<bool> OnlySendConsolidateNotification { get; set; }
    }
}
