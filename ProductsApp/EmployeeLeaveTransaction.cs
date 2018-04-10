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
    
    public partial class EmployeeLeaveTransaction
    {
        public int EmployeeLeaveTransactionID { get; set; }
        public Nullable<int> EmployeeLeaveMasterID { get; set; }
        public Nullable<decimal> CreditLeave { get; set; }
        public Nullable<decimal> DebitLeave { get; set; }
        public string Reason { get; set; }
        public Nullable<decimal> PrvOpeningBalance { get; set; }
        public Nullable<decimal> PrvClosingBalance { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDt { get; set; }
        public Nullable<byte> StatusID { get; set; }
        public Nullable<int> TimeOfRequestID { get; set; }
        public string AccumActionType { get; set; }
        public string AccumActionFlag { get; set; }
    
        public virtual EmployeeLeaveMaster EmployeeLeaveMaster { get; set; }
        public virtual Status Status { get; set; }
    }
}
