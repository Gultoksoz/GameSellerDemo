using System;
using System.Collections.Generic;
using System.Text;
using GameSellerDemo.Entities;

namespace GameSellerDemo.Concrete
{
    public class CampaignManager
    {
        public void SellCampaign(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " bought " + campaign.DiscountName);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            campaign.DiscountRate += 10; 
            Console.WriteLine(campaign.DiscountName + " updated!");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.DiscountName + " has been deleted!");
        }
    }
}
