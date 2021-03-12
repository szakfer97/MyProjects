using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,my name is Szakacsi Ferenc-Adam");
            Console.WriteLine("This programme will make the computer guess the random number you chose");
            try
            {
                Console.WriteLine("Please enter your name:");
                string name, input;
                name = Console.ReadLine();
                Console.WriteLine("Type the number you thought of:");
                int min = 0;
                int max = int.Parse(Console.ReadLine());
                int middle = (min + max) / 2;
                int counter = 1;
                int guess_number;
                Console.WriteLine("Welcome to the game " + name + ",I'll try to guess between " + min + " and " + max + "!");
                Console.WriteLine("Is your number " + middle + " ?\nIf it's your number then write (0) please!\nIf it's too high then write (1) please!\nIf it's too low then write (2) please!");
                input = Console.ReadLine();
                guess_number = Convert.ToInt32(input);
                Console.WriteLine("You selected " + guess_number + " so, ");
                if (guess_number == 0)
                {
                    Console.WriteLine("I won on first try!");
                    return;
                }
                do
                {
                    counter += 1;
                    if (guess_number == 2)
                    {
                        min = middle + 1;
                    }
                    else if (guess_number == 1)
                    {
                        max = middle - 1;
                    }
                    else if (guess_number != 1 || guess_number != 2 || guess_number != 0)
                    {
                        Console.WriteLine("Please write 0, 1 or 2 " + name);
                    }
                    middle = (min + max) / 2;
                    Console.WriteLine("Is your guess " + middle + " ?\nIf it's your guess then write (0) please!\nIf it's too high then write (1) please!\nIf it's too low then write (2) please!");
                    input = Console.ReadLine();
                    guess_number = Convert.ToInt32(input);
                    Console.WriteLine(counter + " tries were needed to find your number ");
                    Console.ReadKey();
                } while (guess_number != 0); 
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }

        }
    }
}
