using System;
using System.Collections.Generic;
using System.Text;
using GameSellerDemo.Entities;

namespace GameSellerDemo.Concrete
{
    public class GameManager
    {
        public void SellGame(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName + " has been purchased.   " + gamer.FirstName + " have fun !");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.GameName + " has been deleted!");
        }
    }
}
