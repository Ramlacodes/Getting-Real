using System.Collections.Generic;
// namespace "StreetFood" kan sagtens ændres til noget andet.
namespace StreetFood
{
    public class MenuPakke
    {
        // Properties fra DCD.
        public int PakkeID { get; set; }
        public string Navn { get; set; }
        public double PrisPrKuvert { get; set; }

        // Laver liste så pakker kan indeholde flere retter.
        public List<Ret> Retter { get; set; }

        
        public MenuPakke(int pakkeID, string navn, double prisPrKuvert)
        {
            PakkeID = pakkeID;
            Navn = navn;
            PrisPrKuvert = prisPrKuvert;
            Retter = new List<Ret>();
        }

        // Tilføjer en ret til pakke.
        public void TilfoejRet(Ret ret)
        {
            Retter.Add(ret);
        }
    }
}