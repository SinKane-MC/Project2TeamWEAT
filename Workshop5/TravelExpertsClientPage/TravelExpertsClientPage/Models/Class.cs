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
    
    public partial class Class
    {
        public Class()
        {
            this.BookingDetails = new HashSet<BookingDetail>();
        }
    
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDesc { get; set; }
    
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
