using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICTACTOE
{
    class Program
    {
        public static bool play = true;
        public static int player = 0;
        public static int turn = 0;
        public static string xTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };
        static void Main(string[] args)
        {
            int row, col;
            do
            {
                Console.WriteLine("Player " + xTurn);
                Console.WriteLine("Enter Row:");

                row = int.Parse(Console.ReadLine());
                if(row != 0 && row != 1 && row != 2)
                {
                    Console.WriteLine("enter valid number.");
                    Console.WriteLine("Enter Row:");
                    row = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter Column:");
                col = int.Parse(Console.ReadLine());
                if(col != 0 && col != 1 && col != 2)
                {
                    Console.WriteLine("enter valid number.");
                    Console.WriteLine("Enter Column:");
                    col = int.Parse(Console.ReadLine());
                }

                while (board[row][col] != " ")
                {
                    Console.WriteLine("That is already played.");
                    Console.WriteLine("Player " + xTurn);
                    Console.WriteLine("Enter Row:");
                    row = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Column:");
                    col = int.Parse(Console.ReadLine());

                }

                board[row][col] = xTurn;
                printBoard();
                if (player == 0)
                {
                    player++;
                    xTurn = "o";
                }
                else
                {
                    player--;
                    xTurn = "x";

                }
            }

            while (play && !CheckForWin() && !CheckForTie());
            {
                Console.ReadLine();

            }
            

        }


        public static bool CheckForWin()
        {
            if (board[0][0] == xTurn && board[0][1] == xTurn && board[0][2] == xTurn)
            {
                return true;
            }
            if (board[1][0] == xTurn && board[1][1] == xTurn && board[1][2] == xTurn)
            {
                return true;
            }
            if (board[2][0] == xTurn && board[2][1] == xTurn && board[2][2] == xTurn)
            {
                return true;
            }


            if (board[0][0] == xTurn && board[1][0] == xTurn && board[2][0] == xTurn)
            {
                return true;
            }
            if (board[0][1] == xTurn && board[1][1] == xTurn && board[2][1] == xTurn)
            {
                return true;
            }
            if (board[0][2] == xTurn && board[1][2] == xTurn && board[2][2] == xTurn)
            {
                return true;
            }
            if (board[0][0] == xTurn && board[1][1] == xTurn && board[2][2] == xTurn)
            {
                return true;
            }
            if (board[0][2] == xTurn && board[1][1] == xTurn && board[2][0] == xTurn)
            {
                return true;
            }
            return false;
        }
        public static int turncount = 9;
        
        public static bool CheckForTie()
        { if( player == turncount)
            {
                Console.Write("tie");
                return true;
                
            }
           


            return false;
        }

        static void printBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-------");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + board[i][j]);
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-------");

        }
    }
}


