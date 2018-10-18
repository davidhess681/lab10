using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validator
    {
        public static double ValidNum()
        {
            string userInput = Console.ReadLine();
            try
            {
                // parse user input to a double, then return it
                double radius = double.Parse(userInput);
                return radius;
            }
            catch (FormatException)
            {
                // if user input is no
                Console.Write("Invalid input. Please enter a number: ");
                return ValidNum();
            }
        }

        public static bool PlayAgain()
        {
            // repeat the program if user types "y", close if "n"
            switch (Console.ReadLine())
            {
                case "y":
                    {
                        return true;
                    }
                case "n":
                    {
                        return false;
                    }
                default:
                    {
                        Console.Write("Invalid. Try again: ");
                        return PlayAgain();
                    }
            }
        }
    }
}
