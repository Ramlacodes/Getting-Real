using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class Kunde
    {
        public string navn { get; set; }
        public string email { get; set; }
        public int telefon { get; set; }


        public Kunde(string Navn, string Email, int Telefon)
        {
            navn = Navn;
            email = Email;
            telefon = Telefon;
        }
    }
}
