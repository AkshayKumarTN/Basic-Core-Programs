using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public static void Readinput()
        {
            Console.Write("Enter the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            IsLeapYear(year);
        }
        public static void IsLeapYear(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                Console.WriteLine("The Year "+year+" is Leap Year.");
            else
                Console.WriteLine("The Year " + year + " is Not Leap Year.");
        }
    }
}
