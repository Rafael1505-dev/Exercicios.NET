using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET06
{
    public static class CurrencyConverterEx6
    {
        public static double iof = 0.06;

        public static double Converter (double dolar, double value) 
        { 
            double valueConverter = dolar * value;
            valueConverter += (valueConverter * iof);
            return valueConverter;
        }
    }
}
