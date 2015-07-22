using System;
using System.Collections.Generic;

namespace TripItinerary.Models
{
    public class Destination
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Activity> Activities { get; set; } 
    }
}