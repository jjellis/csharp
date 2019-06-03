using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind_game
{
    class Program
    {
        static int[] hint;
        int count;
        string[][] board;
        const int attempts = 4;
        const int code = 2;
        static string[] secret = new string[code];
        static string[] color = new string[] { "red", "yellow", "blue" };
       

        static void Main(string[] args)
        {
            //gereate secret
            Random rnd = new Random();
            for (int i = 0; i < 2; i++) 
            {
                secret[i] = color[rnd.Next(0, 2)];

            }
            //ask for input
            Console.WriteLine("what colors do you want to choose?");
            string[] guess = Console.ReadLine().Split(' ');

            while (CorrectAnswers(guess) == false)
            {
                Console.WriteLine("what colors?");
                _ = Console.ReadLine().Split(' ');



            }

        }

        public static bool CorrectAnswers(string[] guess)
        {
            if (guess[0] == secret[0] && guess[1] == secret[1])
            {
                Console.WriteLine("winner");
            }
            else
            {

                int correctcolor = 0;
                int correctpos = 0;
              
                for (int i = 0; i < 2; i++)
                {
                    if (secret.Contains(guess[i]))
                    {
                        correctcolor++;
                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    if (guess[i] == secret[i])
                    {
                        correctpos++;
                    }
                    Console.WriteLine("you hint is " + correctpos + "-" + correctcolor);
                }
            }
        }
    }
}
