using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Szakacsi Ferenc-Adam");
            EvenOdd();
            PosNegs();
            MaxMin();
            Mountain();
            Console.ReadKey();
        }
        private static void EvenOdd()
        {
            try
            {
                int evenCounter = 0;
                int oddCounter = 0;
                Console.WriteLine("1.This programme calculates the number of even and odd numbers");
                Console.Write("Enter the vector's number of elements: ");
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < n; i++)
                    v[i] = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    if (v[i] % 2 == 0)
                        evenCounter++;
                    else
                        oddCounter++;
                }
                Console.WriteLine("There are {0} even numbers and {1} odd numbers", evenCounter, oddCounter);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void PosNegs()
        {
            try
            {
                int positiveCounter = 0;
                int negativeCounter = 0;
                Console.WriteLine("2.This programme calculates the number of positive and negative numbers");
                Console.Write("Enter the vector's number of elements: ");
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < n; i++)
                    v[i] = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    if (v[i] >= 0)
                        positiveCounter++;
                    else
                        negativeCounter++;
                }
                Console.WriteLine("There are {0} positive numbers and {1} negative numbers", positiveCounter, negativeCounter);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void MaxMin()
        {
            try
            {
                Console.WriteLine("3.This programme calculates the maximum and minimum of the vector,and how often it appears");
                Console.WriteLine("Enter the number of elements and the elements themselves: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                int[] f = new int[100000];
                for (int i = 0; i < f.Length; i++)
                    f[i] = 1;
                int max;
                int min;
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                min = max = a[0];
                for (int i = 1; i < n; i++)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                    else if (a[i] == min)
                        f[min]++;
                    else if (a[i] > max)
                    {
                        max = a[i];
                    }
                    else if (a[i] == max)
                        f[max]++;
                }
                Console.WriteLine($"Maximum is {max} and it appears {f[max]} times");
                Console.WriteLine($"Minimum is {min} and it appears {f[min]} times");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Mountain()
        {
            try
            {
                Console.WriteLine("4.This programme shows if a numerical series is a mountain or not (ascending then descending)");
                int j, k, nr;
                int n = int.Parse(Console.ReadLine());
                int[] v;
                bool mountain;
                for (int i = 0; i < n; i++)
                {
                    nr = int.Parse(Console.ReadLine());
                    v = new int[10];
                    j = 0;
                    while (nr > 0)
                    {
                        v[j++] = nr % 10;
                        nr /= 10;
                    }
                    mountain = true;
                    k = 0;
                    while (k + 1 < j && v[k] < v[k + 1])
                    {
                        k++;
                    }
                    if (k == 0)
                    {
                        mountain = false;
                    }
                    if (mountain == true)
                    {
                        if (k == j - 1)
                        {
                            mountain = false;
                        }
                    }
                    if (mountain == true)
                    {
                        while (k + 1 < j && v[k] > v[k + 1])
                        {
                            k++;
                        }
                        if (k + 1 != j)
                        {
                            mountain = false;
                        }
                    }
                    if (mountain == true)
                        Console.WriteLine(1);
                    else
                        Console.WriteLine(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
