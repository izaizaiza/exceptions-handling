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

        public InvalidRadiusException(string message) : base(message)
        {

        }

        //public InvalidRadiusException(string message, Exception inner) : base(message, inner)
        //{

        //}

        public InvalidRadiusException(string message, double radius) : this(message)
        {
            Console.WriteLine(message + radius.ToString() + ". Enter a positive number.");
        } //[1]



    }

    //Reference: [1] https://learn.microsoft.com/en-us/dotnet/standard/exceptions/how-to-create-localized-exception-messages?source=recommendations
}
