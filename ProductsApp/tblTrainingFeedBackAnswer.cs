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
    
    public partial class tblTrainingFeedBackAnswer
    {
        public int FeedbackQuestionLookupId { get; set; }
        public int FeedBackId { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public Nullable<int> CreatedId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual tblTrainingFeedBackMaster tblTrainingFeedBackMaster { get; set; }
        public virtual tblTrainingFeedbackQuestion tblTrainingFeedbackQuestion { get; set; }
    }
}
