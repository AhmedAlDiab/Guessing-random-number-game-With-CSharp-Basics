using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guessing_random_number_game_With_CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Difficulty = 1;
            int NumberToGuess = 1;
            int Guessed = 0;
            while (true)
            {
                Console.Write("Welcome to the Number Guessing Game! You have 7 tries to guess.\nPlease choose difficulty:\n1: Easy (1-10)\n2: Medium (1-100)\n3: Hard (1-1000)\n>> ");
                while (!int.TryParse(Console.ReadLine(), out Difficulty) || Difficulty < 1 || Difficulty > 3)
                {
                    Console.WriteLine("Please enter a value between 1 and 3.");
                }
                switch (Difficulty)
                {
                    case 1:
                        NumberToGuess = random.Next(1, 10);
                        break;
                    case 2:
                        NumberToGuess = random.Next(1, 100);
                        break;
                    case 3:
                        NumberToGuess = random.Next(1, 1000);
                        break;
                    default:
                        break;
                }
                Console.Write("Guess the number: (You have 7 tries) >> ");
                int Tries = 7;
                while (Guessed != NumberToGuess)
                {
                    Tries--;
                    while (!int.TryParse(Console.ReadLine(), out Guessed))
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                    if (Guessed == NumberToGuess)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have won! :) The number is {0}.", NumberToGuess);
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        if (Tries == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You are out of tries! :( You have lost. The number was {0}.", NumberToGuess);
                            Console.ResetColor();
                            break;
                        }
                        else if (Tries > 1)
                        {
                            if (NumberToGuess > Guessed)
                            {
                                Console.Write("Try a higher number -_- You have {0} tries left >> ", Tries);
                            }
                            else
                            {
                                Console.Write("Try a lower number -_- You have {0} tries left >> ", Tries);
                            }
                        }
                        else
                        {
                            if (NumberToGuess > Guessed)
                            {
                                Console.Write("Try a higher number -_- You have {0} try left >> ", Tries);
                            }
                            else
                            {
                                Console.Write("Try a lower number -_- You have {0} try left >> ", Tries);
                            }
                        }
                    }
                }
                Console.Write("Try again? (Y/N) >> ");
                string Ans = Console.ReadLine();
                if (Ans.ToLower() == "y" || Ans.ToLower() == "yes")
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
