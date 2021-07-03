using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class AlphabetIsVowelORConsonant
    {
        public static void Readinput()
        {
            Console.Write("Enter an Alphabet : ");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            VowelORConsonant(alphabet);
        }

        public static void VowelORConsonant(char alphabet)
        {
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }
        }


    }
}
