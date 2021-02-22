using System;
using System.Collections.Generic;
using GameSellerDemo.Abstract;
using System.Text;
using GameSellerDemo.Entities;

namespace GameSellerDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
