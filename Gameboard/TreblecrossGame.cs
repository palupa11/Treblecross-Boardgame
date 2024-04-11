using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Gameboard
{
    internal class TreblecrossGame : BaseGame
    {
        //Initiate objects at class level
        Treblecross game1;
        Human player1;
        TreblecrossBoard board1;
        Move moves;
        int size;


        public override int Menu()
        {
            WriteLine("Welcome!");
            WriteLine("1. New game");
            WriteLine("2. Load saved game");
            WriteLine("3. Exit game");
            WriteLine("To continue, input the option number >>");
            int option = Convert.ToInt32(ReadLine());
            return option;

        }

        public override void DisplayRules()
        {
            
            WriteLine("                                            Treblecross Rules                                                       ");
            WriteLine("_________________________________________________________________________________________________________________");
            WriteLine();
            WriteLine("Two players take turns placing the same X piece on a one-dimensional board with 1 x n squares in size, where n is");
            WriteLine("provided by the user at the start of the game. The first player that forms a line of three X pieces in a row wins!");
            WriteLine("");

            
        }
      

        public override int SetUpGame()          //ref game1 obj, ref object obj2)
        {
            
            //game1 = new Treblecross();
            DisplayRules();
            player1 = new Human();
            size = player1.SelectBoardSize();            
            int opponent = player1.SelectOpponentType();
            board1 = new TreblecrossBoard(size);
            board1.SetBoard(size);
            return opponent;
        }

        public override void SinglePlayerGame()
        {
            //board1.SetBoard(size);


            while (!board1.CheckForWinner(board1.Squares, size))
            {
                int move1 = player1.MakeMove(board1.Squares, size);
                bool validMove = board1.CheckValidMove(board1.Squares, move1, size);
                while (!validMove)
                {

                    move1 = player1.MakeMove(board1.Squares, size);
                    validMove = board1.CheckValidMove(board1.Squares, move1, size);

                }
                board1.SetPiece(move1);
                //moves.SaveMove(move1);
                bool hasWinner = board1.CheckForWinner(board1.Squares, move1);
                if (hasWinner)
                {
                    WriteLine("Player 1 wins!");
                    break;

                }
                
                

                Computer player2 = new Computer(size);
                int move10 = player2.MakeRandomMove();
                bool computerValidMove = board1.CheckValidMove(board1.Squares, move10, size);
                while (!computerValidMove)
                {

                    move10 = player2.MakeRandomMove();
                    computerValidMove = board1.CheckValidMove(board1.Squares, move10, size);

                }
                board1.SetPiece(move10);
                bool computerIsWinner = board1.CheckForWinner(board1.Squares, move10);
                if (computerIsWinner)
                {
                    WriteLine("Computers wins!");

                }


            }

        }


        public override void TwoPlayerGame()
        {
            while (!board1.CheckForWinner(board1.Squares, size))
            {
                int move1 = player1.MakeMove(board1.Squares, size);
                bool validMove = board1.CheckValidMove(board1.Squares, move1, size);
                while (!validMove)
                {

                    move1 = player1.MakeMove(board1.Squares, size);
                    validMove = board1.CheckValidMove(board1.Squares, move1, size);

                }
                board1.SetPiece(move1);
                bool hasWinner = board1.CheckForWinner(board1.Squares, move1);
                if (hasWinner)
                {
                    WriteLine("Player 1 wins!");
                    break;

                }
                Human player2 = new Human();
                int move2 = player1.MakeMove(board1.Squares, size);
                bool validMove2 = board1.CheckValidMove(board1.Squares, move2, size);
                while (!validMove2)
                {

                    move1 = player1.MakeMove(board1.Squares, size);
                    validMove2 = board1.CheckValidMove(board1.Squares, move2, size);

                }
                board1.SetPiece(move2);
                bool hasWinner2 = board1.CheckForWinner(board1.Squares, move2);
                if (hasWinner)
                {
                    WriteLine("Player 2 wins!");
                    break;

                }




            }





        }










    }
     
}