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
    
    public partial class EmployeeAppraisal
    {
        public int EmployeeAppraisalID { get; set; }
        public Nullable<int> EmpID { get; set; }
        public Nullable<int> AppraisalParameterID { get; set; }
        public string AppraisalValue { get; set; }
        public Nullable<System.DateTime> AppraisalDate { get; set; }
        public Nullable<int> AppraisedBy { get; set; }
    }
}
