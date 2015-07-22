using System;

namespace TripItinerary.Models
{
    public class Activity
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Address { get; set; }
    }
}