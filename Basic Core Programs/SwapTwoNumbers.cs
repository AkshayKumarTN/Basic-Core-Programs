using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public static void Readinput()
        {
            Console.Write("\nEnter Number1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Swap(ref number1, ref number2);
            Console.WriteLine("After Swap");
            Console.WriteLine("Number1 : "+number1);
            Console.WriteLine("Number2 : "+number2);
        }
        public static void Swap(ref int number1, ref int number2)
        {
            int temp = number2;
            number2 = number1;
            number1 = temp;
        }
    }
}
