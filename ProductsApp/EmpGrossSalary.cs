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
    
    public partial class EmpGrossSalary
    {
        public int EmpGrossSalID { get; set; }
        public int EmpID { get; set; }
        public string BasicSalary { get; set; }
        public string HRA { get; set; }
        public string ConveryAllowance { get; set; }
        public string FoodAllowance { get; set; }
        public string MedicalAllowance { get; set; }
        public string LTA { get; set; }
        public string BookAllowance { get; set; }
        public string EducationAllowance { get; set; }
        public string ProjectBonus { get; set; }
        public string Incentive { get; set; }
        public string GrossSal { get; set; }
        public string SpecialAllowance { get; set; }
        public string LeaveEncashment { get; set; }
        public string TotalGrossSal { get; set; }
        public string PF { get; set; }
        public string ProfessionalTax { get; set; }
        public string PF_E_3_67 { get; set; }
        public string PF_E_8_33 { get; set; }
        public string PF_E_1_1 { get; set; }
        public string PF_E_0_5 { get; set; }
        public string PF_E_0_01 { get; set; }
        public string ESI_1_75 { get; set; }
        public string ESI_4_75 { get; set; }
        public string CTC { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual employee employee { get; set; }
    }
}