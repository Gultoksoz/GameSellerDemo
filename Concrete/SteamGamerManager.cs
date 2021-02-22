using GameSellerDemo.Abstract;
using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Concrete
{
    public class SteamGamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public SteamGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
 
        }
    }
}
