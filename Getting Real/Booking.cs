using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    internal class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDato { get; set; }
        public int AntalKuvret { get; set; }
        public string Lokation { get; set; }
        public string Status { get; set; }
        public string Kommentar { get; set; }
        public Kunde kunde { get; set; }
        
        

        public double BeregnPris()
        {
            return 0;
        }

    }
}
