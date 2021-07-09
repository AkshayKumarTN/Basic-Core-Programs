using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class ComputeQuotientAndRemainder
    {
        public static void Readinput()
        {
            Console.Write("\nEnter Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Compute(dividend, divisor);
        }
        public static void Compute(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
