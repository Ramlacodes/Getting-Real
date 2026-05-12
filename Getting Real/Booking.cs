using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    internal class Booking
    {
        public int bookingId { get; set; }
        public DateTime bookingDato { get; set; }
        public int antalKuvret { get; set; }
        public string lokation { get; set; }
        public string status { get; set; }
        public string kommentar { get; set; }

        public double BeregnPris()
        {
            return 0;
        }

    }
}
