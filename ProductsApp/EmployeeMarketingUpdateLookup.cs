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
    
    public partial class EmployeeMarketingUpdateLookup
    {
        public int Id { get; set; }
        public int empId { get; set; }
        public bool IsMarketingUpdateRead { get; set; }
        public bool IsOtherUpdateRead { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
