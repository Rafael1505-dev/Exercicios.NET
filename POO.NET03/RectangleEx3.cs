using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET03
{
    public class RectangleEx3
    {
        public double width;
        public double height;


        public double Area()
        {
            double area = width * height;
            return area;
        }
        public double Perimeter()
        {
            double perimeter = 2 * (width + height);
            return perimeter;
        }
        public double Diagonal()
        {
            double dgn = Math.Sqrt(width * width + height * height);
            return dgn;
        }
    }
}
