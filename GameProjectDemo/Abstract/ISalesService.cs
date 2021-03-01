using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameProjectDemo
{
    public interface ISalesService
    {
        void Sell(Game game, CampaignManager campaignManager, Campaign campaign);

    }
}
