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
    
    public partial class EmployeeSkillDetail
    {
        public int EmployeeSkillDetailID { get; set; }
        public int EmployeeSkillID { get; set; }
        public Nullable<int> AppraisalParameterID { get; set; }
        public Nullable<int> technologyID { get; set; }
        public Nullable<decimal> SkillValue { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual EmployeeSkill EmployeeSkill { get; set; }
        public virtual technology technology { get; set; }
    }
}
