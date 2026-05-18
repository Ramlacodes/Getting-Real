using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public interface IPriceCalculator
    {
        // interface til udregning af samlet pris.
        double CalculatePrice(double pricePrServing, int amountOfPlates);
    }
}
