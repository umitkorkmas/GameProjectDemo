using GameProjectDemo.Entities;
using System;
using GameProjectDemo.Concrete;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "ENGİN", LastName="DEMİROĞ", BirthYear = 1985, IdentityNumber = 12345 });
            Console.WriteLine("Hello World!");

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Basketball";
            game1.Price = 25;

            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "Futball";
            game2.Price = 13;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 5;
            campaign1.CampaignName = "Fırsat";
            campaign1.DiscountRate = 15;


            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(game2);
            campaignManager1.Delete(game1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(game1, campaignManager1, campaign1);

        }
    }
}
