using System;
using GameSellerDemo.Abstract;
using GameSellerDemo.Concrete;
using GameSellerDemo.Entities;
using GameSellerDemo.Adapters;

namespace GameSellerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager baseGamerManager = new SteamGamerManager(new MernisServiceAdapter());
            baseGamerManager.Add(new Gamer() {DateOfBirth=new DateTime(2000,06,09), FirstName="Rose", LastName="Dobrev", NationalityId="45454545494", Id=1 });

            Gamer gamer1 = new Gamer() { FirstName="Ian", LastName="Somerhalder", DateOfBirth= new DateTime(1970,05,06), NationalityId="45456512157", Id=2};
            BaseGamerManager baseGamerManager1 = new EpicGamerManager();
            baseGamerManager1.Add(gamer1);
            baseGamerManager1.Update(gamer1);
            

            Game game = new Game() {GameName="The Room 4", Developer= "Fireproof Games", Publisher= "Fireproof Games", ReleaseDate= new DateTime(2021,02,11) };
            GameManager gameManager = new GameManager();
            gameManager.SellGame(gamer1, game);

            Campaign campaign = new Campaign() {DiscountId=1, DiscountName="The Room 4 campaign", DiscountRate=20, DiscountStore="Steam" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.SellCampaign(gamer1, campaign);
            campaignManager.UpdateCampaign(campaign);

            baseGamerManager1.Delete(gamer1);
            gameManager.DeleteGame(game);

            Console.ReadLine();
        }
    }
}
