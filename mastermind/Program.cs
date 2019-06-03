using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {   //1.generate code
           
            string[] color = { "yellow", "red", "blue"};
            int[] hint;
            int trycount;
            const int attempts = 4;
            const int codelength = 2;
            string[] secret = new string[codelength];
            Random generator = new Random();
            int index = generator.Next(0, 2);
            secret[0] = color[randomIndex];
            int index = generator.Next(0, 2);
            secret[1] = color[randomIndex];
            string[] input = new string[] { " ", " " };
            for (int=0; int < 2; int++)
            {
                secret[i] = color[Random.next(0, 2)];
            }
            string replay = "yes";
            while (replay == "yes")
            {
                //2.ask input
                Console.WriteLine("Guess what colors I picked? Pick two: blue, red, or yellow? What is the first color");
                input = Console.ReadLine().ToLower().Split(' ');


                //3.give hint for wrong answer
                //else winnnnnnerrrrrr
                if (correctguess (input))
                {


                    Console.Write("Winner you choose right.");
                    break;
                }
                else 
                {

                    hint(guess);
                    update(guess);
                    Console.WriteLine("your hint ")
                        count++
                }
                Console.WriteLine("Play again? Yes or No");
                replay = Console.ReadLine().ToLower();
            }
            public void sectetcolor()
            {
                secret[0]
            }
        }
    }
}
