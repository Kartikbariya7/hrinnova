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
    
    public partial class tblKPIFunction
    {
        public int KPIFunctionID { get; set; }
        public int KPIID { get; set; }
        public int FunctionID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<bool> IsMandatory { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public Nullable<int> Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_on { get; set; }
    
        public virtual Lookup Lookup { get; set; }
        public virtual tblFunction tblFunction { get; set; }
        public virtual tblKPI1 tblKPI { get; set; }
    }
}