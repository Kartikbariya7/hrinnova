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
    
    public partial class tblProjectStatusAnswer
    {
        public int ProjectStatusAnswerID { get; set; }
        public string AnswerText { get; set; }
        public int QuestionId { get; set; }
        public int Answeredby { get; set; }
        public System.DateTime Answeredon { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public bool IsDeleted { get; set; }
        public int MeetingId { get; set; }
    
        public virtual tblProjectMeeting tblProjectMeeting { get; set; }
    }
}
