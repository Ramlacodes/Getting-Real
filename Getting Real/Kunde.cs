using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class Kunde
    {
        public string Navn { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }


        public Kunde(string navn, string email, int telefon)
        {
            Navn= navn;
            Email = email;
            Telefon = telefon;
        }
    }
}
