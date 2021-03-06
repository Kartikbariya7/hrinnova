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
    
    public partial class Penalty
    {
        public int PenaltyID { get; set; }
        public string PenaltyName { get; set; }
        public byte PenaltyConfigTypeID { get; set; }
        public Nullable<byte> PenaltyTypeID { get; set; }
        public Nullable<byte> ShiftTypeID { get; set; }
        public Nullable<short> AllowLimitMin { get; set; }
        public Nullable<short> AllowLimitMax { get; set; }
        public Nullable<short> PenaltyPoints { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDt { get; set; }
        public Nullable<byte> StatusID { get; set; }
        public Nullable<int> PolicyID { get; set; }
        public string Comment { get; set; }
    
        public virtual PenaltyConfigType PenaltyConfigType { get; set; }
        public virtual PenaltyType PenaltyType { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual ShiftType ShiftType { get; set; }
        public virtual Status Status { get; set; }
    }
}
