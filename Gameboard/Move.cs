using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gameboard
{
    internal class Move
    {
        private int move;
        private List<int> moveList = new List<int>();

        public void MoveOptions()
        {
            WriteLine("Happy with your move?");
            WriteLine("Choose one of the following options:");
            WriteLine("1. Go to next player's move");
            WriteLine("2. Undo your move");


        }



        public void UndoMove(List<int> squares, int move)
        {
            int size = squares.Count;
            squares.RemoveAt(size);


        }

        public void SaveMove(int move)
        {
            moveList.Add(move);
        }

        public void RedoMove(List<int> moveList, List<int>squares)
        {
            int lastMoveIndex = moveList.Count;
            int lastMove = moveList[lastMoveIndex];
            squares.Add(lastMove);






        }






    }
}
