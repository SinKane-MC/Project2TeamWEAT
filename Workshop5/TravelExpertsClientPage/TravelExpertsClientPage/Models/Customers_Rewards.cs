//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelExpertsClientPage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customers_Rewards
    {
        public int CustomerId { get; set; }
        public int RewardId { get; set; }
        public string RwdNumber { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Reward Reward { get; set; }
    }
}
