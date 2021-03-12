using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My name is Szakacsi Ferenc-Adam");
            Interchange();
            Transpose();
            MaxMin();
            Console.ReadKey();
        }
        private static void Interchange()
        {
            try
            {
                int i, j, aux = 0;
                Console.WriteLine("1.This progamme does the interchange between 2 rows");
                Console.WriteLine("Introduce the number of rows and columns:");
                int r = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int[,] m = new int[r, c];
                Console.WriteLine("Introduce the matrix elements:");
                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.Write("M[{0}][{1}]=", i, j);
                        m[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Matrix looks like this:");
                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                        Console.Write(m[i, j] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine("Type the row you want changed: 1 - {0}", r);
                int r1 = int.Parse(Console.ReadLine());
                r1--;
                Console.WriteLine("Type the row you want it to be changed with: 1 - {0}", r);
                int r2 = int.Parse(Console.ReadLine());
                r2--;
                for (i = 0; i < c; i++)
                {
                    aux = m[r1, i];
                    m[r1, i] = m[r2, i];
                    m[r2, i] = aux;
                }
                Console.WriteLine("Matrix after the interchange:");
                for (i = 0; i < r; i++)
                {
                    for (j = 0; j < c; j++)
                        Console.Write(m[i, j] + " ");
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Transpose()
        {
            try
            {
                int i, j;
                Console.WriteLine("2.This programme will show the transpose of a matrix");
                Console.WriteLine("Introduce the number of rows and columns:");
                int c = int.Parse(Console.ReadLine());
                int l = int.Parse(Console.ReadLine());
                float[,] m = new float[c, l];
                Console.WriteLine("Introduce the matrix elements:");
                for (i = 0; i < c; i++)
                    for (j = 0; j < l; j++)
                    {
                        Console.Write("M[{0}][{1}]=", i, j);
                        m[i, j] = float.Parse(Console.ReadLine());
                    }
                Console.WriteLine("Matrix looks like this:");
                for (i = 0; i < c; i++)
                {
                    for (j = 0; j < l; j++)
                    {
                        Console.Write(m[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Transpose of the matrix will be:");
                float[,] ta = new float[l, c];
                for (i = 0; i < c; i++)
                    for (j = 0; j < l; j++)
                        ta[i, j] = m[j, i];
                for (i = 0; i < l; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.Write(ta[i, j] + " ");
                    }
                    Console.WriteLine();
                }
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
                int i, j, max, min;
                Console.WriteLine("3.This programme calculates a matrix's maximum and minimum,and shows the position they're in");
                Console.WriteLine("Introduce the number of rows and columns:");
                int l = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int[,] m = new int[l, c];
                Console.WriteLine("Introduce the matrix elements:");
                for (i = 0; i < l; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.Write("A[{0}][{1}]=", i, j);
                        m[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Matrix looks like this:");
                for (i = 0; i < l; i++)
                {
                    for (j = 0; j < c; j++)
                        Console.Write(m[i, j] + " ");
                    Console.WriteLine();
                }
                max = m[0, 0];
                for (i = 0; i < l; i++)
                {
                    for (j = 0; j < c; j++)
                        if (m[i, j] > max)
                            max = m[i, j];
                }
                Console.WriteLine($"Maximum is {max}");
                Console.WriteLine("Maximum is found in:");
                for (i = 0; i < l; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        if (m[i, j] == max)
                            Console.WriteLine("Position [{0},{1}]", i + 1, j + 1);
                    }
                }
                min = m[0, 0];
                for (i = 0; i < l; i++)
                {
                    for (j = 0; j < c; j++)
                        if (m[i, j] < min)
                            min = m[i, j];
                }
                Console.WriteLine($"Minimum is {min}");
                Console.WriteLine("Minimum is found in:");
                for (i = 0; i < l; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        if (m[i, j] == min)
                            Console.WriteLine("Position [{0},{1}]", i + 1, j + 1);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
