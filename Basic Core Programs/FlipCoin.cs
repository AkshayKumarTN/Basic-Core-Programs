using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class FlipCoin
    {
        public static void Readinput()
        {
            Console.WriteLine("Enter the number of times to Flip Coin : ");
            int number_Of_Times = Convert.ToInt32(Console.ReadLine());
            FindPersentage(number_Of_Times);
        }
        public static void FindPersentage(int number_Of_Times)
        {
            int head = 0, tail = 0;
            Random random = new Random();
            for(int i=0;i<number_Of_Times;i++)
            {
                double value = random.NextDouble();
                if (value <0.5)
                    tail++;
                else
                    head++;
            }
            double persentage_Of_Head = (double)head / number_Of_Times * 100;
            double persentage_Of_Tail = (double)tail / number_Of_Times * 100;
            Console.WriteLine("Persentage of Head is " + persentage_Of_Head);
            Console.WriteLine("Persentage of Tail is " + persentage_Of_Tail);
        }
    }
}
