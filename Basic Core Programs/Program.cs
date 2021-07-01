using System;

namespace Basic_Core_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the options:");
            Console.WriteLine("1.Flip Coin");
            Console.WriteLine("2.Leap Year");
            Console.WriteLine("3.Largest Among Three Number");
            Console.WriteLine("4.Alphabet Is Vowel Or Consonant");
            Console.WriteLine("5.Prime Factors Of Number N");
            Console.Write("Enter the Option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin.Readinput();
                    break;
                case 2:
                    LeapYear.Readinput();
                    break;
                case 3:
                    LargestAmongThreeNumbers.Readinput();
                    break;
                case 4:
                    Alphabet_Is_Vowel_OR_Consonant.Readinput();
                    break;
                case 5:
                    Prime_Factors_Of_Number.Readinput();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;
            }
          
        }
    }
}
