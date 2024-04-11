using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gameboard
{
    internal class TreblecrossBoard : IBoard
    {

        private List<int> squares = new List<int>();

        //private List<int> moveList = new List<int>();

        public List<int> Squares { get { return squares; } }
        public int Size { get; set; }

        //Constructor

        public TreblecrossBoard(int size)
        {
            this.Size = size;
        }

        public TreblecrossBoard(List<int> squareList)
        {
            this.squares = squareList;

        }

        /*public int Size 
        {
            get { return size; }
            set
            {
                size = value;
                SelectBoardSize();


            } 
        
        
        }   */


        public void SetBoard(int size)
        {
            
            Write("+");
            for (int i = 0; i < size; i++)
            {
                Write("---+");
            }
            WriteLine();

            
            Write("| ");
            for (int i = 0; i < size; i++)
            {
                if(squares.Contains(i+1))
                {
                    Write("X");

                }
                else
                {
                    Write(" ");
                }
                Write(" | ");

                
            }
            WriteLine();

            Write("+");
            for (int i = 0; i < size; i++)
            {
                Write("---+");
            }
            WriteLine();
        }





        public void SetPiece(int x)
        {
            WriteLine("entrando a set piece ");
            WriteLine(x);            
            squares.Add(x);
            SetBoard(Size);


        }

        public bool CheckValidMove(List<int> squares, int move, int size)
        {
            Console.WriteLine("Entrando a checkvalidmove");            
            if (squares.Contains(move) || move > size)                  
            {
                Console.WriteLine("Invalid move.Try Again");
                return false;
            }
            else
            {
                Console.WriteLine("Valid Move!");
                return true;
            }

           


        }

        public bool CheckForWinner(List<int> squares, int move)
        {
            /*WriteLine("Entrando a check for winner, VAMO A VER");*/
            
                if (squares.Contains(move) && squares.Contains(move - 1) && squares.Contains(move + 1))
                {
                    WriteLine("you are the winner!!!!");
                    return true;
                }
                else if (squares.Contains(move) && squares.Contains(move - 1) && squares.Contains(move - 2))
                {
                    WriteLine("you are the winner VERSION 2!!!!");
                    return true;
                }
                else if (squares.Contains(move) && squares.Contains(move + 1) && squares.Contains(move +2))
                {
                    WriteLine("you are the winner VERSION 3!!!!");
                    return true;
                }

                else
                {
                   /* WriteLine("Keep playing, no winner so far");*/
                    return false;

                }



        }

        /*public int UndoMove(List<int> squares, int move)
        {
            int size = squares.Count;
            squares.RemoveAt(size);


        }

        public int SaveMove(List<int> moveList, int move)
        {



        }

        public int RedoMove()
        {




        }
*/



    }


    
}
