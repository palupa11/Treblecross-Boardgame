using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gameboard
{
    internal abstract class Player
    {
        //Data fields    //DEBERIAN SER PRIVADOS

        private string playerType;
       

        //Propertiers
        public string PlayerType
        {
            get { return playerType; }
            set { playerType = value; }
        }
        public int PlayerNum { get; set; }

        //Constructors
/*
        public Player (string type, int num)
        {
            this.PlayerType = type;
            this.PlayerNum = num;   

        }*/

        //Methods    
        protected abstract void AssignPlayerType();

        protected abstract void AssignPlayerNum();
        




    }
}
