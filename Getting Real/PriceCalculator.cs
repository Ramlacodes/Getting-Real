using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public class PriceCalculator : IPriceCalculator
    {
        public double CalculatePrice(double pricePrPlate, int amountOfPlates)
        {
            if (amountOfPlates <= 0)
            {
                Console.WriteLine("Antal kuverter skal være positivt.");
                return 0;
            }

            else
            {

                return pricePrPlate * amountOfPlates;
            }
        }

    }
}

       
