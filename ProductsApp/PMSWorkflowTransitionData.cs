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
    
    public partial class PMSWorkflowTransitionData
    {
        public int PMSWorkflowTransitionDataID { get; set; }
        public int ProjectID { get; set; }
        public int TaskStatusID { get; set; }
        public int DestinationTaskStatusID { get; set; }
        public int PMSWorkflowID { get; set; }
        public int WBSID { get; set; }
        public string ControlJson { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual PMSWorkflow PMSWorkflow { get; set; }
        public virtual project project { get; set; }
        public virtual tblTaskStatu tblTaskStatu { get; set; }
        public virtual tblTaskStatu tblTaskStatu1 { get; set; }
        public virtual WB WB { get; set; }
    }
}
