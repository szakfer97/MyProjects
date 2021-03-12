using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldbachConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Szakacsi Ferenc-Adam");
            Console.WriteLine("This programme will use Goldbach's conjecture");
            try
            {
                int number, firstNumber, secondNumber = 0;
                Console.WriteLine("Write a number:");
                number = int.Parse(Console.ReadLine());
                for (firstNumber = 1; firstNumber <= number / 2; firstNumber = firstNumber + 2)
                {
                    if (CheckPrimeNumber(firstNumber))
                    {
                        secondNumber = number - firstNumber;
                        if (CheckPrimeNumber(secondNumber))
                            Console.WriteLine($"{number} is the sum of prime numbers {firstNumber} + {secondNumber}");
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        static bool CheckPrimeNumber(int number)
        {
            bool prime = true;
            int i = 2;
            while (i <= number / 2)
            {
                if (number % i == 0)
                    prime = false;
                i += 1;
            }
            return prime;
        }
    }
}
