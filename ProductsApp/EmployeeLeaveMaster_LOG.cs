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
    
    public partial class EmployeeLeaveMaster_LOG
    {
        public int ID { get; set; }
        public Nullable<int> EmployeeLeaveMasterID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> LeaveCategoryID { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public Nullable<decimal> UpdatedOpeningBalance { get; set; }
        public Nullable<decimal> ClosingBalance { get; set; }
        public Nullable<decimal> UpdatedClosingBalance { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedByEmployeeID { get; set; }
        public string HostName { get; set; }
        public string LoginName { get; set; }
        public string Server_IPAddress { get; set; }
        public string Client_IPAddress { get; set; }
        public string protocol_type { get; set; }
        public string PROG_NAME { get; set; }
    }
}
