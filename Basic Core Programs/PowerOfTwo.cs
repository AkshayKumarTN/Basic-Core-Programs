using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOfTwo
    {
        public static void Readinput()
        {
            Console.Write("\nEnter the Power Number (N) : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Compute(number);
        }
        public static void Compute(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(" 2^"+i+" = "+result);
            }
        }
    }
}
