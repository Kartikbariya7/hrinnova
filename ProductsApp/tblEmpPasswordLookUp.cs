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
    
    public partial class tblEmpPasswordLookUp
    {
        public int EmpPasswordLookUpID { get; set; }
        public int EmpPasswordTrackID { get; set; }
        public string EmpPassword { get; set; }
    
        public virtual tblEmpPasswordTrack tblEmpPasswordTrack { get; set; }
    }
}
