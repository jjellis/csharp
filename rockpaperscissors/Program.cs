using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string replay = "yes";
            while (replay == "yes") 
            {
                Random generator = new Random();
                // creates a number 0,1 or 2
                int randomNumber = generator.Next(0, 3);
                Console.WriteLine("Rock, Paper, Scissors?");
            string player = Console.ReadLine().ToLower();


                {
                    if (randomNumber == 1)
                    {
                        if (player == "rock")
                        {
                            Console.WriteLine("The computer choses paper");
                            Console.WriteLine("You lose. Maybe next time.");

                        }
                        else if (player == "paper")
                        {
                            Console.WriteLine("The computer choses scissors");
                            Console.WriteLine("You lose. Maybe next time.");

                        }
                        else if (player == "scissors")
                        {
                            Console.WriteLine("The computer choses rock");
                            Console.WriteLine("You lose. Maybe next time.");
                        }
                        else
                        {
                            Console.WriteLine("Choose rock, paper or scissors!");
                        }

                    }

                    else if (randomNumber == 2)
                    {
                        if (player == "rock")
                        {
                            Console.WriteLine("The computer choses scissors");
                            Console.WriteLine("You win");

                        }
                        else if (player == "paper")
                        {
                            Console.WriteLine("The computer choses rock");
                            Console.WriteLine("You win");

                        }
                        else if (player == "scissors")
                        {
                            Console.WriteLine("The computer choses paper");
                            Console.WriteLine("You win");

                        }
                        else
                        {
                            Console.WriteLine("Choose rock, paper or scissors!");

                        }
                        ;
                    }

                    if (randomNumber == 0)
                    {
                        if (player == "rock")
                        {
                            Console.WriteLine("The computer choses rock!");
                            Console.WriteLine("TIE!!");

                        }
                        else if (player == "paper")
                        {
                            Console.WriteLine("The computer choses paper!");
                            Console.WriteLine("TIE!!");

                        }
                        else if (player == "scissors")
                        {
                            Console.WriteLine("The computer choses scissors!");
                            Console.WriteLine("TIE!!");
                        }
                        else
                        {
                            Console.WriteLine("Choose rock, paper or scissors!");

                        }



                    }
                    Console.WriteLine("Play again? Yes or No");
                    replay = Console.ReadLine().ToLower();


                }

            }
        }
    }
    }

        
    