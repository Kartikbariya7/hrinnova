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
    
    public partial class TrainingEmployeeLog
    {
        public int TrainingEmpLogID { get; set; }
        public long TrainingDetailID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> ExternalTrainerId { get; set; }
        public Nullable<System.DateTime> MailSendDate { get; set; }
        public bool IsTrainer { get; set; }
        public bool IsFeedback { get; set; }
        public bool IsWaiver { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsChange { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual ExternalTrainerDetail ExternalTrainerDetail { get; set; }
        public virtual TrainingDetail TrainingDetail { get; set; }
    }
}