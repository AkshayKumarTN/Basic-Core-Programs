using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public static void Readinput()
        {
            Console.WriteLine("Enter the number of times to Flip Coin : ");
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());
            FindPersentage(numberOfTimes);
        }
        public static void FindPersentage(int numberOfTimes)
        {
            int head = 0, tail = 0;
            Random random = new Random();
            for(int i=0;i< numberOfTimes; i++)
            {
                double value = random.NextDouble();
                if (value <0.5)
                    tail++;
                else
                    head++;
            }
            double persentageOfHead = (double)head / numberOfTimes * 100;
            double persentageOfTail = (double)tail / numberOfTimes * 100;
            Console.WriteLine("Persentage of Head is " + persentageOfHead);
            Console.WriteLine("Persentage of Tail is " + persentageOfTail);
        }
    }
}
