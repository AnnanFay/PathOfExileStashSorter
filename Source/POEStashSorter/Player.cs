//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POEStashSorter
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        public long Id { get; set; }
        public Nullable<long> Credits { get; set; }
        public Nullable<long> RegionId { get; set; }
        public Nullable<long> TeamId { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Region Region { get; set; }
    }
}