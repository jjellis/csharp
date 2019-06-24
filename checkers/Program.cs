using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkers
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.Start();
        }
    }
    public Checker()
    {

    }
    public void MoveChecker(Checker checker, Position destination)
    {
        Checker c = new Checker(checker.team, destination.row, destination.Column);
        checkers.Remove(checker);
        checkers.Add(c);
        RemoveChecker(checker);
    }
    public void RemoveChecker(Checker checker)
    {
        if (checker != null)
        {
            checkers.Remove(checker);
        }
        ///TODO: what if checker==null?
    }
    #region Methods
    public Checker GetChecker(Postion source)
    {//linq can be used to select checker or this
        ///TODO: Use LINQ to implement this function
        foreach (checkers c in checkers)
        {
            if (c.postion.Row == source.Row && c.position.Column == source.Column)
            {
                return c;
            }
        }
        return null;
    }
    public void MoveChecker()
    {

    }

    private bool CheckForWin()
    {

    }

    public void start()
    {

    }

    public bool LegalMove(Color player, Position source, Position destination)
    {
        //1. bothe source postion and the destiantion position myst be integers between 0 and 7
        if (source.Row < 0 || source.Row > 7 || source.Column < 0 || source.Column > 7 || destination.Row < 0 || destination.Row > 7 || destination.Column < 0 || destination.Column > 7) return false;

        //2.the destion point and souce point must fall on the same line with the slope = 1 or -1 or the absolute value of the slope must be 1
        int rowDistance = Math.Abs(destination.Row - source.Row);
        int colDistance = Math.Abs(destination.Column - source.Column);
        //make sure the demnomiator is not equil to zero
        if (colDistance == 0 || rowDistance == 0) return false;
        if (rowDistance > 2) return false;

        //3. if we reach here that means the destionaion position and the source position are on the same line
        //but we need to make sure the destionat can only be ip to two steps away from the soure if there is a pice in betweein
        if (rowDistance > 2) return false;

        //4. now we have made sure that the destionation position and the source position are on the same line with the
        //correct distance.. there must be a chekcer at the source postion
        checkers c = board.GetChecker(source);
        if (c == null) return false;
        // there must be no checker at destionion postion 
        c = board.GetChecker(destination);
        if (c != null) return false;

        //5. now er need to make sure the moving direction and length
        if (rowDistance == 2)
        {
            if (IsCapture(player, source, destination))
            {
                return true;
            }
            return false;
        }
        else //implies that rowDistance ==1 
        {
            if (rowDistance == 1) return true;
            
        }
    }
        // the white checker can only go down
        
            //this means that the destination.row should be greater then the source.row 
            // if destination.row - souce.row = 2
            

                //there must be a pice in the middle 
                
                }
                
            }
        

       public bool IsCapture(Color player, Position source, Position dest)
           {
             int rowDitance = Math.Abs(destination.Row - source.Row);
             int colDistance = Math.Abs(destination.Column - source.Column);
             if (rowDistance == 2 && colDistance == 2)
            {
            int row_mid = (destination.Row + source.Row) / 2;
            int col_mid = (destination.Column + source.Column) / 2;
            Position p = new Position(row_mid, Col_mid);
            Checker c = board.GetChecker(p);
            if (c == null)
            {
                return false;
            }
            else
            {
                if (c.Team == player)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    public Checker GetCaptureChecker(Color player, Position src, Position dest)
    {
        if (IsCapture(player, source, destination))
        {
            int row_mid = (destination.Row + source.Row) / 2;
            int col_mid = (destination.Column + source.Column) / 2;
            Postion p = new postion(row_mid, col_mid);
            Checker c = Board.GetChecker(p);
            return c;
        }
        return null;
    }



     public void ProcessInput()
     {

     }

public struct Position
{
    public int row { get; private set; }
    public int col { get; private set; }
    public Position(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}

public enum Color { White, Black }

public class Checker
{
    public String symbol { get; private set; }
    public Color team { get; private set; }
    public Position position { get; set; }

    public Checker(Color team, int row, int col)
    {
        // ...  
    }

}

public class Board
{
    public List<Checker> checkers;
    public Board()
    {
        checkers = new List<Checker>();
        for (int r = 0; r < 3; r++)
        {
            for (int i = 0; i < 8; i += 2)
            {
                Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                checkers.Add(c);
            }
            for (int i = 0; i < 8; i += 2)
            {
                Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                checkers.Add(c);
            }
        }
    }

    public Checker GetChecker(Position pos)
    {
        //..
    }

    public void RemoveChecker(Checker checker)
    {
        // ...
    }

    public void MoveChecker(Checker checker, Position dest)
    {
        // ..
    }

}

public class Game
{
    private Board board;
    public Game()
    {
        this.board = new Board();
    }

    private bool CheckForWin()
    {
        // ..
    }

    public void Start()
    {
        // ...
    }

    public bool IsLegalMove(Color player, Position src, Position dest)
    {
        // ...        
    }

    public bool IsCapture(Position src, Position dest)
    {
        // ...
    }

    public Checker GetCaptureChecker(Position src, Position dest)
    {
        // ..

    }

    public Position ProcessInput()
    {
        // ...
    }

    public void DrawBoard()
    {
        String[][] grid = new String[8][];
        for (int r = 0; r < 8; r++)
        {
            grid[r] = new String[8];
            for (int c = 0; c < 8; c++)
            {
                grid[r][c] = " ";
            }
        }
        foreach (Checker c in board.checkers)
        {
            grid[c.position.row][c.position.col] = c.symbol;
        }
        
        Console.WriteLine("  0 1 2 3 4 5 6 7");
        for (int r = 0; r < 8; r++)
        {
            Console.Write(r);
            for (int c = 0; c < 8; c++)
            {
                Console.Write(" {0}", grid[r][c]);
            }
            Console.WriteLine();
        }
    }


}

