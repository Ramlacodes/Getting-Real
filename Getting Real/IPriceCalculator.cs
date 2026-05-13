using System;
using System.Collections.Generic;
using System.Text;

namespace Getting_Real
{
    public interface IPriceCalculator
    {
        double CalculatePrice(double pricePrServing, int antalKuverter);
    }
}
