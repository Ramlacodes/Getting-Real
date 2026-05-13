using System.Collections.Generic;
// Har ændret mit namespace til "Getting_Real"
namespace Getting_Real
{
    public class MenuPackage
    {
        // Properties fra DCD.
        public int PackageID { get; set; }
        public string Name { get; set; }
        public double PricePrServing { get; set; }

        // Laver liste så pakker kan indeholde flere retter.
        public List<Ret> Retter { get; set; }

        
        public MenuPackage(int packageID, string name, double pricePrServing)
        {
            PackageID = packageID;
            Name = name;
            PricePrServing = pricePrServing;
            Retter = new List<Ret>();
        }

      
    }
}
