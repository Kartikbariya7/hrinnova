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
    
    public partial class EmployeeHistory
    {
        public int EmployeeHistoryID { get; set; }
        public int EmpID { get; set; }
        public int ColumnTypeID { get; set; }
        public string LastValue { get; set; }
        public string ModifiedValue { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
