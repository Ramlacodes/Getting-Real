using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class PriceCalculator : IPriceCalculator
    {
        public double CalculatePrice(double pricePrServing, int antalKuverter)
        {
            if (antalKuverter <= 0)
            {
                Console.WriteLine("Antal kuverter skal være positivt.");
                return 0;
            }

            else
            {

                return pricePrServing * antalKuverter;
            }
        }

    }
}

       
