using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static int repeats = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!");

            do
            {
                Console.Write("\nEnter radius: ");

                // validate user input then assign it to a double variable
                double radius = Validator.ValidNum();

                // create a new instance of a Circle, setting the Radius to our double "radius" above
                Circle circle = new Circle(radius);

                // assign these strings from Circle.cs to new strings (more on their function over there)
                string circumference = circle.CalculateFormattedCircumference();
                string area = circle.CalculateFormattedArea();

                // print results to the console
                Console.WriteLine(circumference);
                Console.WriteLine(area);

                // increment the amount of repeats by 1
                Console.Write("\nContinue? (y/n): ");
                repeats++;
            }
            while (Validator.PlayAgain());

            // tell user how many circles they have created (if/else statement changes the grammer depending on repeats being 1 or not)
            if (repeats == 1)
            {
                Console.WriteLine("\nThank you for making {0} circle! Press any key to close.", repeats);
            }
            else
            {
                Console.WriteLine("\nThank you for making {0} circles! Press any key to close.", repeats);
            }
            Console.ReadKey();
        }
        
    }
    
}
