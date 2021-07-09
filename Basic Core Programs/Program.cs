using System;

namespace BasicCorePrograms
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
            Console.WriteLine("6.Swap Two Numbers");
            Console.WriteLine("7.Compute Quotient And Remainder");
            Console.WriteLine("8.Check Whether a Number is Even or Odd");
            Console.WriteLine("9.Nth Harmonic Number");
            Console.WriteLine("10. Power Of Two");
            Console.Write("\nEnter the Option : ");
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
                    AlphabetIsVowelORConsonant.Readinput();
                    break;
                case 5:
                    PrimeFactorsOfNumber.Readinput();
                    break;
                case 6:
                    SwapTwoNumbers.Readinput();
                    break;
                case 7:
                    ComputeQuotientAndRemainder.Readinput();
                    break;
                case 8:
                    NumberIsEvenOrOdd.Readinput();
                    break;
                case 9:
                    HarmonicNumber.Readinput();
                    break;
                case 10:
                    PowerOfTwo.Readinput();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;
            }
          
        }
    }
}
