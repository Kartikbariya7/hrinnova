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
    
    public partial class ReviewDefect
    {
        public int ReviewDefectID { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<System.DateTime> ReviewDate { get; set; }
        public Nullable<int> ReviewTypeId { get; set; }
        public Nullable<int> ReviewCycleNumber { get; set; }
        public Nullable<int> StageDetected { get; set; }
        public Nullable<int> StageAttributedToId { get; set; }
        public Nullable<int> DocumentTypeId { get; set; }
        public string DocumentName { get; set; }
        public Nullable<int> PriorityId { get; set; }
        public Nullable<int> SeverityId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string ProblemObserved { get; set; }
        public string Assignee { get; set; }
        public string AssignedTo { get; set; }
        public Nullable<int> StatusId { get; set; }
        public string ClosureDate { get; set; }
        public string Remark { get; set; }
        public string Resolution { get; set; }
        public string RootCause { get; set; }
        public Nullable<int> RootCauseCategoryId { get; set; }
        public Nullable<int> RootCauseSubcategoryDocId { get; set; }
        public Nullable<int> RootCauseSubcategoryCodeId { get; set; }
        public Nullable<System.DateTime> EnteredDatetime { get; set; }
    }
}
