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
    
    public partial class EmployeeCompetencyDetail
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<int> TechnologyId { get; set; }
        public Nullable<int> DomainId { get; set; }
        public Nullable<int> IndustryId { get; set; }
        public Nullable<int> Rating { get; set; }
        public string ProficiencyBrief { get; set; }
        public string CompentencyName { get; set; }
        public int CompetencyTypeId { get; set; }
        public Nullable<int> ExperienceMonth { get; set; }
        public Nullable<int> SpanMasterID { get; set; }
        public Nullable<bool> IsLock { get; set; }
    
        public virtual domain domain { get; set; }
        public virtual employee employee { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual tblSkillMatrixSpanMaster tblSkillMatrixSpanMaster { get; set; }
        public virtual technology technology { get; set; }
    }
}
