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
    
    public partial class tblProjectStatusQuestion
    {
        public int ProjectStatusQuestionId { get; set; }
        public string QuestionText { get; set; }
        public bool IsDefault { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public int Created_By { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public bool IsDeleted { get; set; }
        public int QuestionType { get; set; }
        public bool IsMandatory { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual Lookup Lookup { get; set; }
        public virtual project project { get; set; }
    }
}