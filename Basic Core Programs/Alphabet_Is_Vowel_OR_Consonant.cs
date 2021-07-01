using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Alphabet_Is_Vowel_OR_Consonant
    {
        public static void Readinput()
        {
            Console.Write("Enter an Alphabet : ");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            Vowel_OR_Consonant(alphabet);
        }

        public static void Vowel_OR_Consonant(char alphabet)
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
