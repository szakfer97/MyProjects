using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersofHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("My name is Szakacsi Ferenc-Adam"); 
                Console.WriteLine("This programme solves the Hanoi Towers problem");
                char firstPeg = 'A';
                char tempPeg = 'B';
                char lastPeg = 'C';
                Console.WriteLine("Type the number of disks:");
                int Hanoi = int.Parse(Console.ReadLine());
                SolveTowers(Hanoi, firstPeg, tempPeg, lastPeg);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void SolveTowers(int n, char firstPeg, char tempPeg, char lastPeg)
        {
            if (n > 0)
            {
                SolveTowers(n - 1, firstPeg, tempPeg, lastPeg);
                Console.WriteLine("Disk is moved from " + firstPeg + " to " + lastPeg);
                SolveTowers(n - 1, tempPeg, lastPeg, firstPeg);
            }
        }
    }
}
