using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class PrisBeregner : IPrisBeregner
    {
        
    public double BeregnPris(Booking booking)
        {
            if (booking == null)
                throw new ArgumentNullException(nameof(booking));

            if (booking.MenuPakke == null)
                throw new Exception("Booking mangler menu pakke");

            return booking.AntalKuverter * booking.MenuPakke.PrisPrKuvert;
        }

    }
}
