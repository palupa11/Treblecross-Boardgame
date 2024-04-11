using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gameboard
{
    internal class Human : Player
    {
        //DATA FIELDS HEREDADOS DE PLAYER CLASS
        private string PlayerType = "Human";
        private int playerNum = 1; //QUE PASA CON EL PLAYER 2 HUMANO?


        protected override void AssignPlayerNum()
        {

        }

        protected override void AssignPlayerType()
        {

        }

        public int SelectOpponentType()
        {
            int opponentType;
            const int humanOpponent = 1;
            const int computerOpponent = 2;

            WriteLine("Choose a game type");
            WriteLine("For a single player game press 1");
            WriteLine("For a two player game press 2");

            do
            {
                string entryLine = ReadLine();
                if (int.TryParse(entryLine, out opponentType))
                {
                    if (opponentType == humanOpponent || opponentType == computerOpponent)
                    {
                        return opponentType;

                    }


                }
                WriteLine("Invalid game type. Please enter 1 for single player game or 0 for two player game");


            }
            while (true);


        }

        public int SelectBoardSize()                 //Treblecross SPECIFIC
        {
            int boardSize;

            WriteLine("Choose the size of the board");
            WriteLine("Enter a number to set the length of the board >>");

            do
            {
                string entryLine = ReadLine();
                if (int.TryParse(entryLine, out boardSize))
                {

                    return boardSize;



                }
                WriteLine("Invalid board size. Please enter a number to set the length of the board");


            }
            while (true);




        }

        public int MakeMove(List <int> squares, int size)
        {
            Console.WriteLine("Entrando a makemove");
            int move;
            WriteLine("Make your move!");
            WriteLine("Enter a tile number>>");

            do
            {
                string entryLine = ReadLine();
                if (int.TryParse(entryLine, out move))
                {
                    if(move > 0 && move <= size)
                    {
                        return move;
                    }
                 
                }
                WriteLine("Your input must be a number between 1 and {0}", size);


            }
            while (true);




        }








    }
      
    
    
    
    
    
    







    
}
