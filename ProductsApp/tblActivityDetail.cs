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
    
    public partial class tblActivityDetail
    {
        public int ActivityDetailId { get; set; }
        public int ActivityTypeId { get; set; }
        public int UserId { get; set; }
        public string ActivityContent { get; set; }
        public string FileName { get; set; }
        public System.DateTime ActivityDate { get; set; }
        public int TaskID { get; set; }
        public Nullable<bool> IsStatusChange { get; set; }
        public Nullable<int> StatusId { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual tblTaskStatu tblTaskStatu { get; set; }
        public virtual tblActivityType tblActivityType { get; set; }
        public virtual tblTaskStatu tblTaskStatu1 { get; set; }
        public virtual WB WB { get; set; }
    }
}
