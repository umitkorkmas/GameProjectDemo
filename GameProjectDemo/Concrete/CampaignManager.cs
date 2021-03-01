using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }

        internal void Delete(Game game1)
        {
            Console.WriteLine("oyundan kampanya silindi");
        }

        internal void Add(Game game2)
        {
            Console.WriteLine("oyuna kapmanyaeklendi");
        }
    }
}
