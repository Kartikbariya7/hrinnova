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
    
    public partial class tblEvaluationComment
    {
        public int EvaluationCommentId { get; set; }
        public int KRAAssignDetailId { get; set; }
        public int CreatedById { get; set; }
        public int CommentTypeId { get; set; }
        public string Comments { get; set; }
        public string AttachementName { get; set; }
        public bool IsVisibletoEmp_Mgr { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual tblCommentType tblCommentType { get; set; }
        public virtual tblKRAAssignDetail tblKRAAssignDetail { get; set; }
    }
}
