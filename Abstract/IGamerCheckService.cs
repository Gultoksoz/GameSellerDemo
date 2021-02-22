using System;
using System.Collections.Generic;
using GameSellerDemo.Entities;
using System.Text;

namespace GameSellerDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
