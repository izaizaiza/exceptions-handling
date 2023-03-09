using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // try 4 types of input: negative, 0, positive, not a number
            for (int j = 0; j < 4; j++)
            {
                try
                {
                    Console.WriteLine("Enter radius of a circle:");
                    double radius = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    Console.WriteLine(circle.Area);
                }
                catch (InvalidRadiusException e)
                {
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                Console.ReadLine();
            }
        }
    }
}
