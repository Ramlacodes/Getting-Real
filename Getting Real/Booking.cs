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
        public string Lokation { get; set; }
        public string bookingStatus { get; set; }
        public string Kommentar { get; set; }
        public Kunde kunde { get; set; }
        
        

       

    }
}
