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
    
    public partial class clientcontact
    {
        public int ClientContactID { get; set; }
        public int ClientID { get; set; }
        public string GUID { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string BusinessPhoneNumber1 { get; set; }
        public string BusinessPhoneNumber2 { get; set; }
        public string CellNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string ChatID { get; set; }
        public Nullable<byte> PrimaryContact { get; set; }
    
        public virtual Client Client { get; set; }
    }
}