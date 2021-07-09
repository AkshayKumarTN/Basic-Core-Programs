using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class HarmonicNumber
    {
        public static void Readinput()
        {
            Console.Write("\nEnter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Compute(number);
        }
        public static void Compute(int number)
        {
            float harmonic = 1;
                      
            for (int i = 2; i <= number; i++)
            {
                harmonic += (float)1 / i;
            }

            Console.WriteLine(" "+number+ "th Harmonic Number : " + harmonic);
        }
    }
}
