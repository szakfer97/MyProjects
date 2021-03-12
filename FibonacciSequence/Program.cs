using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Szakacsi Ferenc-Adam");
            NTerms();
            EvenOrOddNumbers();
            SumNum();
        }
        private static void NTerms()
        {
            try
            {
                Console.WriteLine("1.This programme shows the Fibonacci sequence");
                Console.WriteLine("Type the number of terms to be shown:");
                int n = int.Parse(Console.ReadLine());
                double Num1 = 0, Num2 = 1, Numf;
                Console.WriteLine("First number is 0");
                for (int i = 2; i <= n; i++)
                {
                    Numf = Num1 + Num2;
                    Num2 = Num1;
                    Num1 = Numf;
                    Console.WriteLine($"Number {i} is {Numf}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void EvenOrOddNumbers()
        {
            try
            {
                Console.WriteLine("2.This programme shows the number of even and odd numbers");
                Console.WriteLine("Type the number of terms to be shown:");
                int n = int.Parse(Console.ReadLine());
                int even = 0;
                int odd = 0;
                double Num1 = 0, Num2 = 1, Numf;
                Console.WriteLine("First number is 0");
                for (int i = 2; i <= n; i++)
                {
                    Numf = Num1 + Num2;
                    Num2 = Num1;
                    Num1 = Numf;
                    if (Numf % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                    Console.WriteLine("Number {0} is {1} ", i, Numf);
                }
                Console.WriteLine($"Number of even numbers is {even}");
                Console.WriteLine($"NUmber of odd numbers is {odd}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void SumNum()
        {
            try
            {
                Console.WriteLine("3.This programme shows the sum of numbers");
                Console.WriteLine("Type the number of terms to be shown:");
                int n = int.Parse(Console.ReadLine());
                double sum = 0;
                double Num1 = 0, Num2 = 1, Numf;
                Console.WriteLine("First number is 0");
                for (int i = 2; i <= n; i++)
                {
                    Numf = Num1 + Num2;
                    Num2 = Num1;
                    Num1 = Numf;
                    sum += Numf;
                    Console.WriteLine($"Number {i} is {Numf}");
                }
                Console.WriteLine($"Sum of the terms is {sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
