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
    
    public partial class EmployeeDeviceMapping
    {
        public int EmpDeviceMappingId { get; set; }
        public int EmpId { get; set; }
        public string DeviceId { get; set; }
        public int DevicePlatform { get; set; }
        public string DeviceModel { get; set; }
        public string DevicePlatformVersion { get; set; }
        public bool Islatest { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual employee employee { get; set; }
    }
}
