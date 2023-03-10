using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingLab
{
    internal class InvalidRadiusException: Exception
    {
        public InvalidRadiusException() 
        {
         
        }

        /// <summary>
        /// takes in radius value and incorporate in the Console.write... message
        /// </summary>
        /// <param name="radius"></param>
        public InvalidRadiusException(double radius)
        {
            Console.WriteLine("Radius, " + Convert.ToString(radius) + " is invalid. Enter a positive number.");
        } //[1]

        /// <summary>
        /// takes in a message specified when used; for when radius=0
        /// </summary>
        /// <param name="message"></param>
        public InvalidRadiusException(string message) : base(message)
        {
            Console.WriteLine(message);
        }




    }

    //Reference: [1] https://learn.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-localized-exception-messages?source=recommendations
}
