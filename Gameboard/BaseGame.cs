using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gameboard
{
    public abstract class BaseGame
    {
        public abstract int Menu();

        public abstract void DisplayRules();
        public abstract int SetUpGame();                          //ref object x ,ref object y );

        public abstract void SinglePlayerGame();

        public abstract void TwoPlayerGame();







    }
}
