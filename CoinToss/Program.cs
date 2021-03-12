using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            HeadsOrTails();
        }
        private static void HeadsOrTails()
        {
            try
            {
                int numPlays = 0, numWins = 0;
                int compChoice = 0;
                char userChoice;
                double percentWin;
                Random rnd = new Random();
                while (true)
                {
                    Console.WriteLine("Write H or h to guess heads,T ot t to guess tails,Q or q to quit the game");
                    userChoice = Console.ReadKey().KeyChar;
                    compChoice = rnd.Next(0, 2);
                    if (char.ToLowerInvariant(userChoice) != 'q')
                    {
                        if (char.ToLowerInvariant(userChoice) == 'h' && compChoice == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("YOU WON");
                            numWins++;
                        }
                        else if (char.ToLowerInvariant(userChoice) == 't' && compChoice == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("YOU WON");
                            numWins++;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("YOU LOSE");
                        }
                        numPlays++;
                    }
                    else
                    {
                        percentWin = (double)numWins / numPlays;
                        Console.WriteLine();
                        Console.WriteLine($"You won {numWins} out of {numPlays} games or {percentWin} of the games played.");
                        break;
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
