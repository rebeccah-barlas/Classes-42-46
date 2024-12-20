using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_42_46
{
    public class Triangle
    {
        public static double Side1Length { get; set; }
        public static double Side2Length { get; set; }
        public static double Side3Length { get; set; }
        public Triangle (double side1Length, double side2Length, double side3Length)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
        }
        public static double CalculatePerimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }
        public static double CalculateArea()
        {
            double s = (Side1Length + Side2Length + Side3Length) / 2; // Semi-perimeter
            return Math.Sqrt(s * (s - Side1Length) * (s - Side2Length) * (s - Side3Length));
        }
    }
}
