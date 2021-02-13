using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Game game,Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" uygulandı. İndirim oranı %"+campaign.CampaignDiscount+"! "+ (game.GamePrice * campaign.CampaignDiscount / 100)+" TL daha az ödeyeceksiniz.");
        }

        

       
    }
}
