using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public interface ICampaignService
    {
        void Add(Campaign campaign, Game game);
        void Delete(Campaign campaign, Game game);
        void Update(Campaign campaign, Game game);

    }
}
