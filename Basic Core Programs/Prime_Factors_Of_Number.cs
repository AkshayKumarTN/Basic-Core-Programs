using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PrimeFactorsOfNumber
    {
        public static void Readinput()
        {
            Console.Write("Enter the Number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            PrimeFactors(Number);
        }
        public static void PrimeFactors(int Number)
        {
            while (Number % 2 == 0)
            {
                Console.Write(2 + " ");
                Number /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(Number); i += 2)
            {
                while (Number % i == 0)
                {
                    Console.Write(i + " ");
                    Number /= i;
                }
            }

            if (Number > 2)
                Console.Write(Number);
        }
    }
}
