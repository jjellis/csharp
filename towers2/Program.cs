using System;
using System.Collections;

namespace Towers
{
    internal class Program
    {
        //Vairables
        private static Stack A = new Stack();
        private static Stack B = new Stack();
        private static Stack C = new Stack();
        private static object move = " ";
        private static string moveString = " ";
        private static int moveInt = -1;
        private static object compare = " ";
        private static string compareString = " ";
        private static int compareInt = -1;
        private static bool winner = false;

        private static void Main(string[] args)
        {
            //Push the values into the first stack
            A.Push(4);
            A.Push(3);
            A.Push(2);
            A.Push(1);


            while (winner == false)
            {
                // Print Board
                Console.Write("A: ");
                foreach (int i in A)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\nB: ");
                foreach (int i in B)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\nC: ");
                foreach (int i in C)
                {
                    Console.Write(i + " ");
                }

                // Player selects a row to move a number from
                Console.WriteLine(" ");
                Console.WriteLine("_______________________________");
                Console.WriteLine("Select a row. A, B, or C");
                string playerSelect = Console.ReadLine().ToLower();
                Console.WriteLine(" ");

                // Pop the top value off the stack the player selected
                if (playerSelect == "a")
                {
                    move = A.Pop();
                }

                if (playerSelect == "b")
                {
                    move = B.Pop();
                }

                if (playerSelect == "c")
                {
                    move = C.Pop();
                }

                // Convert the popped value to a integer for comparison later
                moveString = move.ToString();
                moveInt = Int32.Parse(moveString);
                // Player selects a row to move a number to
                Console.WriteLine("Stored value: " + moveString);
                Console.WriteLine("Select a row to place the number.");
                string playerDestination = Console.ReadLine().ToLower();

                // Check if the stack the player chose is valid
                if (playerDestination == "a")
                {
                    // Push popped value to empty stack
                    if (A.Count == 0)
                    {
                        A.Push(move);
                    }
                    // Compare the popped value with the top value of the destination stack
                    else
                    {
                        compare = A.Peek();
                        compareString = compare.ToString();
                        compareInt = Int32.Parse(compareString);
                        if (moveInt > compareInt)
                        {
                            A.Push(move);
                        }
                        else
                        {
                            Console.WriteLine("Invalid move.");
                            Console.Read();
                        }
                    }
                }

                if (playerDestination == "b")
                {
                    // Push popped value to empty stack
                    if (B.Count == 0)
                    {
                        B.Push(move);
                    }
                    // Compare the popped value with the top value of the destination stack
                    else
                    {
                        compare = B.Peek();
                        compareString = compare.ToString();
                        compareInt = Int32.Parse(compareString);
                        if (moveInt > compareInt)
                        {
                            B.Push(move);
                        }
                        else
                        {
                            Console.WriteLine("Invalid move.");
                            Console.Read();
                        }
                    }
                }

                if (playerDestination == "c")
                {
                    // Push popped value to empty stack
                    if (C.Count == 0)
                    {
                        C.Push(move);
                    }
                    // Compare the popped value with the top value of the destination stack
                    else
                    {
                        compare = C.Peek();
                        compareString = compare.ToString();
                        compareInt = Int32.Parse(compareString);
                        if (moveInt > compareInt)
                        {
                            C.Push(move);
                        }
                        else
                        {
                            Console.WriteLine("Invalid move.");
                            Console.Read();
                        }
                    }
                }
                // When all 4 values have been moved to stack C break out of the loop
                if (C.Count == 4)
                {
                    winner = true;
                }
                Console.Clear();
            }
            Console.WriteLine("You Win!!!");
            Console.Read();
        }
    }
}