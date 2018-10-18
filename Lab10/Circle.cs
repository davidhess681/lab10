using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        public Circle(double radius)
        {
            // constructor method to initialize our new circle

            // set double Radius to the number we passed in
            Radius = radius;
        }
        public double Radius { get; set; }

        public double CalculateCircumference()
        {
            // multiply radius by pi * 2 and return the answer
            return Radius * Math.PI * 2;
        }

        public string CalculateFormattedCircumference()
        {
            // format circumference and return a statement displaying the circumference
            double circum = CalculateCircumference();
            return "Circumference: " + FormatNumber(circum);
        }

        public double CalculateArea()
        {
            // square radius, multiply by pi, then return the answer
            return Radius * Radius * Math.PI;
        }

        public string CalculateFormattedArea()
        {
            // format area and return a statement displaying the area
            double area = CalculateArea();
            return "Area: \t" + FormatNumber(area);
        }

        private string FormatNumber(double x)
        {
            // cast our double into a decimal
            decimal y = (decimal)x;

            // round to 2 decimal places
            decimal rounding = Decimal.Round(y, 2);

            // return formatted decimal as a string
            return rounding.ToString();
        }

        
    }
}
