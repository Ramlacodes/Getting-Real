using System;
using System.Collections.Generic;
using System.Text;
// Igen, namespace "StreetFood" kan ændres.
namespace StreetFood
{
    
    public class Ret
    {
        // Properties fra DCD.
        public int RetID { get; set; }
        public string Navn { get; set; }
        public bool Vegetarisk { get; set; }

       
        public Ret(int retID, string navn, bool vegetarisk = false)
        {
            RetID = retID;
            Navn = navn;
            Vegetarisk = vegetarisk;
        }

        // Viser info om retten.
        public override string ToString()
        {
            // Hvis retten er vegetarisk, tilføjes "Vegetarisk" til navnet. Hvis ikke, vises kun navnet.
            string veg = Vegetarisk ? " [Vegetarisk]" : "";
            return $"{Navn}{veg}";
        }
    }
}