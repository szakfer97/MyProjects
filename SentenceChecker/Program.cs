using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Szakacsi Ferenc-Adam");
            CharConVow();
            UpLowNum();
        }
        private static void CharConVow()
        {
            Console.WriteLine("This programme checks the number of characters,vowels and consonants in a sentence");
            Console.WriteLine("Write a sentence:");
            try
            {
                char[] characters = Console.ReadLine().ToCharArray();
                int vowels = 0;
                int consonants = 0;
                int index = 0;
                while (index < characters.Length)
                {
                    if (Char.IsLetter(characters[index]))
                    {
                        switch (characters[index])
                        {
                            case 'a':
                            case 'e':
                            case 'i':
                            case 'o':
                            case 'u':
                                vowels++;
                                break;
                            default:
                                consonants++;
                                break;
                        }
                    }
                    index++;
                }
                Console.WriteLine($"Number of characters is {characters.Length}");
                Console.WriteLine($"Number of consonants is {consonants}");
                Console.WriteLine($"Number of vowels is {vowels}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void UpLowNum()
        {
            try
            {
                int countUpper = 0;
                int countLower = 0;
                int countNumbers = 0;
                Console.WriteLine("This programme will show the number of upper case letters,lower case letters and numeric elements");
                Console.WriteLine("Write a sentence:");
                char[] myString = Console.ReadLine().ToCharArray();
                int length = myString.Length;
                for (int i = 0; i < length; i++)
                {
                    int converted = Convert.ToInt32(myString[i]);
                    if (converted >= 65 && converted <= 90)
                        countUpper++;
                    else if (converted >= 97 && converted <= 122)
                        countLower++;
                    else if (converted >= 48 && converted <= 57)
                        countNumbers++;
                }
                countUpper = countLower = countNumbers = 0;
                foreach (char c in myString)
                {
                    if (char.IsUpper(c))
                        countUpper++;
                    else if (char.IsLower(c))
                        countLower++;
                    else if (char.IsNumber(c))
                        countNumbers++;
                }
                Console.WriteLine($"We have {countUpper} upper cases,{countLower} lower cases,{countNumbers} numbers");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
