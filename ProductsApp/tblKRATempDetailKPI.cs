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
    
    public partial class tblKRATempDetailKPI
    {
        public int KRATempDetailKPIId { get; set; }
        public int KRATempDetailId { get; set; }
        public int KPIId { get; set; }
    
        public virtual tblKPI tblKPI { get; set; }
        public virtual tblKRATempDetail tblKRATempDetail { get; set; }
    }
}
