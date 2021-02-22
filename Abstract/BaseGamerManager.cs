using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " added.");
        }

        public void Delete(Gamer gamer)
        {
            gamer.FirstName = "";
            gamer.LastName = "";
            gamer.Id = 0;
            gamer.NationalityId = "";
            Console.WriteLine("the gamer deleted.");
        }

        public void Update(Gamer gamer)
        {
            gamer.Id = 2;
            gamer.FirstName = "Joseph";
            gamer.LastName = "Morgan";
            gamer.NationalityId = "48484859231";
            Console.WriteLine("update was successful.");
        }
    }
}
