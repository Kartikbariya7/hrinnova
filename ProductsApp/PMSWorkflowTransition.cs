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
    
    public partial class PMSWorkflowTransition
    {
        public int TransitionID { get; set; }
        public int PMSWorkflowID { get; set; }
        public int TaskStatusID { get; set; }
        public int DestinationTaskStatusID { get; set; }
        public string Description { get; set; }
        public Nullable<int> CustomScreenID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual PMSCustomScreen PMSCustomScreen { get; set; }
        public virtual PMSWorkflow PMSWorkflow { get; set; }
        public virtual tblTaskStatu tblTaskStatu { get; set; }
        public virtual tblTaskStatu tblTaskStatu1 { get; set; }
    }
}