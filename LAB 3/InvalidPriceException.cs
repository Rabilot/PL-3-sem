using System;

namespace LAB_3
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("Invalid price!")
        {
            
        }
    }
}