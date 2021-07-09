using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class NumberIsEvenOrOdd
    {
        public static void Readinput()
        {
            Console.Write("\nEnter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            EvenOrOdd(number);
        }
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("The Number "+number+" is even");
            else
                Console.WriteLine("The Number " + number + " is odd");
        }
    }
}
