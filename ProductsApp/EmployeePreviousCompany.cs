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
    
    public partial class EmployeePreviousCompany
    {
        public int PreviousEmpID { get; set; }
        public int EmployeeID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string LastPositionHeld { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string NatureOfDuties { get; set; }
        public string ReasonOfLeaving { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
