using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Gameboard
{
    internal class Computer : Player
    {

        //DATA FIELDS HEREDADOS DE PLAYER CLASS
        private string PlayerType;
        private int playerNum = 1 ; //QUE PASA CON EL PLAYER 2 HUMANO?
        private int randomMoveLimit;
        protected override void AssignPlayerNum()
        {

        }

        protected override void AssignPlayerType()
        {

        }
        //CONSTRUCTOR para pasar size of the board

        public Computer()
        {
           
        }
        public Computer (int size)
        {
            randomMoveLimit = size;

        }
        
        
        public int MakeRandomMove()
        {
            Random random = new Random();
            int move = random.Next(1, randomMoveLimit);
            return move;


        }



    }
}
