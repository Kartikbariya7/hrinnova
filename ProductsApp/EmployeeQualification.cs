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
    
    public partial class EmployeeQualification
    {
        public int EmpQualifictionID { get; set; }
        public int empID { get; set; }
        public int DegreeID { get; set; }
        public int PassingYear { get; set; }
        public string ExamCode { get; set; }
        public string ExamID { get; set; }
        public string Place { get; set; }
        public string CertificationBody { get; set; }
        public string Grade { get; set; }
        public string MainSubject { get; set; }
        public string Remarks { get; set; }
        public string EmpCertAttachment { get; set; }
        public Nullable<System.DateTime> CertificateExpiryDate { get; set; }
    
        public virtual degree degree { get; set; }
        public virtual employee employee { get; set; }
    }
}
