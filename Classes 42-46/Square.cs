using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_42_46
{
    public class Square
    {
        public static double SideLength {  get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }
        public static double CalculatePerimeter()
        {
            return SideLength * 4;
        }
        public static double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
