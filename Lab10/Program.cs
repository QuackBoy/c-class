using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of first side");
            firstSide = double.Parse(Console.ReadLine);
            Console.Write("Enter length of second side");
            Side = double.Parse(Console.ReadLine);
            double hypo = CalcHypotenuse(firstSide, secondSide);
            Console.Write(hypo);
            Console.ReadLine();
        }
        // The Hypotenuse Method
        // Purpose: After finding the length of two sides of the triangle the length of the hypotenuse is found
        // Parameters: Two sides as a double
        // Returns: Hypotenuse side as a double
        static double CalcHypotenuse(double side1, double side2)
        {
            // Ask user to input lengths of two sides of a triangle and stored in seperate variables
            // Hypotenuse formula is implemented
            double hypo = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            // Result is displayed
            Console.Write("The hypotenuse is: {0:f}", hypo);
          
        }
    }
}
