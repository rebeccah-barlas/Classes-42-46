using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_42_46
{
    public static class Point
    {
        public static double X { get; set; }
        public static double Y { get; set; }
        public static void SetPoint (double x, double y)
        {
            X = x;
            Y = y;
        }
        public static double CalculateDistance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public static (double X, double Y) CalculateMidpoint(double x1, double y1, double x2, double y2) // use of a "tuple" due to static class. Able to group small sets of related values that may not be of the same type
        {
            double midpointX = (x1 + x2) / 2;
            double midpointY = (y1 + y2) / 2;
            return (midpointX, midpointY); // returning the "tuple"
        }
    }
}
