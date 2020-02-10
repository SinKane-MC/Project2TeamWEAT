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
    
    public partial class Booking
    {
        public Booking()
        {
            this.BookingDetails = new HashSet<BookingDetail>();
        }
    
        public int BookingId { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public string BookingNo { get; set; }
        public Nullable<double> TravelerCount { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string TripTypeId { get; set; }
        public Nullable<int> PackageId { get; set; }
    
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Package Package { get; set; }
        public virtual TripType TripType { get; set; }
    }
}
