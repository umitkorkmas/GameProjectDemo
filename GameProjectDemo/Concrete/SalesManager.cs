using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class SalesManager : ISalesService
    {
        public void Sell(Game game, CampaignManager campaignManager, Campaign campaign)
        {
            Console.WriteLine("Satılacak ürüne kampanya eklendi");
        }


    }
}
