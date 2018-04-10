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
    
    public partial class PMSWorkflow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PMSWorkflow()
        {
            this.PMSWorkflowTransitions = new HashSet<PMSWorkflowTransition>();
            this.PMSWorkflowTransitionDatas = new HashSet<PMSWorkflowTransitionData>();
            this.PMSWorkflowWorkItemMappings = new HashSet<PMSWorkflowWorkItemMapping>();
        }
    
        public int PMSWorkflowID { get; set; }
        public int ProjectID { get; set; }
        public string WorkflowName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual project project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMSWorkflowTransition> PMSWorkflowTransitions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMSWorkflowTransitionData> PMSWorkflowTransitionDatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PMSWorkflowWorkItemMapping> PMSWorkflowWorkItemMappings { get; set; }
    }
}
