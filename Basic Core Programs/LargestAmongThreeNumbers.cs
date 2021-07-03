using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LargestAmongThreeNumbers
    {
        public static void Readinput()
        {
            Console.Write("Enter Number1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number3 : ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            LargestNumber(number1, number2, number3);
        }

        public static void LargestNumber(int number1,int number2,int number3)
        {
            if(number1>number2&&number1>number3)
                Console.Write("Largest Among Three Number is "+number1);
            else if(number2>number3)
                Console.Write("Largest Among Three Number is "+number2);
            else
                Console.Write("Largest Among Three Number is "+number3);

        }
    }
}
