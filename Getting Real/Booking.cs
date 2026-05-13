using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string eventType { get; set; }
        public DateTime BookingDato { get; set; }
        public int AntalKuverter { get; set; }
        public string Location { get; set; }
        public string bookingStatus { get; set; }
        public string Comment { get; set; }
        public Customer customer { get; set; }
        
        

       

    }
}
