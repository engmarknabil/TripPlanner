//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TripItinerary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Destination
    {
        public Destination()
        {
            this.Activities = new HashSet<Activity>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int TripId { get; set; }
    
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
