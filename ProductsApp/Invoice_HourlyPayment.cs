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
    
    public partial class Invoice_HourlyPayment
    {
        public int InvoiceHouryPaymentID { get; set; }
        public int InvoiceID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> InvoiceRaised { get; set; }
        public Nullable<System.DateTime> InvoiceRaisedDate { get; set; }
        public Nullable<bool> PaymentReceived { get; set; }
        public Nullable<System.DateTime> PaymentReceivedDate { get; set; }
        public Nullable<System.DateTime> LastEmailDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<double> PaymentAmount { get; set; }
    
        public virtual Invoices_Project Invoices_Project { get; set; }
    }
}
