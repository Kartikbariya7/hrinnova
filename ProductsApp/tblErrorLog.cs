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
    
    public partial class tblErrorLog
    {
        public int ErrorLogId { get; set; }
        public string ApplicationName { get; set; }
        public string FileName { get; set; }
        public string ModuleName { get; set; }
        public string MethodName { get; set; }
        public string ErrorMessage { get; set; }
        public string InnerException { get; set; }
        public string StackTrace { get; set; }
        public Nullable<System.DateTime> ExceptionGeneratedOn { get; set; }
        public string ExceptionGeneratedBy { get; set; }
        public Nullable<bool> delete { get; set; }
        public string ClientIP { get; set; }
        public string ServerIP { get; set; }
    }
}