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
    
    public partial class Risk
    {
        public int RiskId { get; set; }
        public string Description { get; set; }
        public Nullable<int> SourceId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string AssignedTo { get; set; }
        public Nullable<int> Impact { get; set; }
        public string Probability { get; set; }
        public Nullable<int> SeverityId { get; set; }
        public Nullable<int> ActionOnRiskId { get; set; }
        public string DefineAlternatives { get; set; }
        public string MitigationPlan1 { get; set; }
        public Nullable<int> StatusId1 { get; set; }
        public string MitigationPlan2 { get; set; }
        public Nullable<int> StatusId2 { get; set; }
        public string MitigationPlan3 { get; set; }
        public Nullable<int> StatusId3 { get; set; }
        public string MitigationPlan4 { get; set; }
        public Nullable<int> StatusId4 { get; set; }
        public string MitigationPlan5 { get; set; }
        public Nullable<int> StatusId5 { get; set; }
        public string ContingencyPlan { get; set; }
        public Nullable<System.DateTime> RiskRaisedDate { get; set; }
        public Nullable<System.DateTime> ExpectedCloseDate { get; set; }
        public Nullable<System.DateTime> ActualCloseDate { get; set; }
        public Nullable<int> Status { get; set; }
        public string Notes { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> Entereddatetime { get; set; }
        public Nullable<int> ProjectId { get; set; }
    }
}
