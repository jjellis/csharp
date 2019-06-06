using System;
using System.Collections.Generic;

namespace towersofhanoi
{
    class Program
    {
        // dictionary. 
        static Dictionary<String, Stack<int>> Towers = new Dictionary<String, Stack<int>>();
        static int size = 4;
        static string orignal, moved;
        static void Main(string[] args)
        {


            //Write rules
            
            Console.Write("Get the number from A to C the numbers must always be bigest to smallest\n");                  

            //Set tower Dictionary.
            Towers.Add("A", new Stack<int> { });
            for (int x = size; x > 0; x--)
            {
                Towers["A"].Push(x);
            }
            Towers.Add("B", new Stack<int> { });
            Towers.Add("C", new Stack<int> { });
            

           
            while (Wins())
            {
                     
                Board();                
                move();
            }
                        
            Board();
            Console.Write("you win");
            Console.Read();
        }


        //board set up
        public static void Board()
        {
            //initialization.
            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();
            Stack<int> First = new Stack<int>(Towers["A"]);
            while (First.Count != 0)
            {
                A.Push(First.Pop());
            }
            First = new Stack<int>(Towers["B"]);
            while (First.Count != 0)
            {
                B.Push(First.Pop());
            }
            First = new Stack<int>(Towers["C"]);
            while (First.Count != 0)
            {
                C.Push(First.Pop());
            }

            for (int y = 0; y < size + 1; y++)
            {
                if (y == size)
                {
                    Console.Write("   A   B   C");
                }
                else
                {
                    Console.Write(" |  ");
                    if (A.Count == 0)
                        Console.Write("  ");
                    else
                    {
                        Console.Write(A.Pop());
                    }
                    if (B.Count == 0)
                        Console.Write("  ");
                    else
                    {
                        Console.Write(B.Pop());
                    }
                    if (C.Count == 0)
                        Console.Write("   ");
                    else
                    {
                        Console.Write(C.Pop());
                    }

                }
            }
        }


        //pick to move 
        static void move()
        {
            
            Console.Write(" A, B, or C?");
            orignal = Console.ReadLine().ToLower();           
            ValidateMove(ref orignal);
            Console.Write("where you want to move?");
            moved = Console.ReadLine().ToLower();            
            ValidateMove(ref moved);
            NotEmpty();
            Legalmove();

            
        }
        //validates moves
        static void ValidateMove(ref string x)
        {
            while (x != "A" && x != "B" && x != "C")
            {
                Console.WriteLine("Invalid Choice!!)");
                x = Console.ReadLine().ToLower();                
            }
        }
        //sees if tower empty
        static void NotEmpty()
        {
            if (Towers[orignal].Count == 0)                
            {
                Console.WriteLine("choose again.");
                move();
            }
        }
       // makes sure bigger numbers cant be on smaller numbers
        static void Legalmove()
        {
            if (Towers[moved].Count != 0)             
            {
                if (Towers[moved].Peek() < Towers[orignal].Peek())
            
                {
                    Console.WriteLine("bigger numbers cant be on smaller numbers!!");
                    move();
                }
            }
        }
       
        //win
       public static bool Wins()
        {
            if (C.Count == size)
                return true;
            
        }
    }

}