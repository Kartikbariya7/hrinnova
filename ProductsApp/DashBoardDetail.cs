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
    
    public partial class DashBoardDetail
    {
        public int DBDID { get; set; }
        public int DBTtypeId { get; set; }
        public string Heading { get; set; }
        public string DBDContent { get; set; }
        public bool DBDStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public string ImageName { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual DashBoardType DashBoardType { get; set; }
        public virtual employee employee1 { get; set; }
    }
}