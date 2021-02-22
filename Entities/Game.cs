using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Entities
{
   public class Game:IEntity
    {
        public string GameName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
    }
}
