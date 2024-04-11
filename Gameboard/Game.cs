using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace Gameboard
{
    internal class Game
    {
        static void Main(string[] args)
        {
            TreblecrossGame game = new TreblecrossGame();
            int option = game.Menu();

            if (option == 1)
            {
                int opponent = game.SetUpGame();
                

                if (opponent == 1)
                {
                    game.SinglePlayerGame();
                                        
                }
                else if (opponent == 2)
                {

                    game.TwoPlayerGame();

                }
                else
                {
                    Console.WriteLine("El ELSE del tipo de juego");
                    
                }
               
            




                













            }


        }
}   } 
