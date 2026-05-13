using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class Kunde
    {
        public string KundeNavn { get; set; }
        public string KundeEmail { get; set; }
        public int KundeTelefon { get; set; }


        public Kunde(string kundeNavn, string kundeEmail, int kundeTelefon)
        {
            KundeNavn= kundeNavn;
            KundeEmail = kundeEmail;
            KundeTelefon = kundeTelefon;
        }
    }
}
