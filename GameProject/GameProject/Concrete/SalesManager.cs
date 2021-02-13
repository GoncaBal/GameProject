using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, User user, Campaign campaign)
        {
            Console.WriteLine(game.GameName+ " kampanya indirimiyle "+" "+ (game.GamePrice-(game.GamePrice * campaign.CampaignDiscount / 100)) + " TL'ye satın alındı.");
        }

        public void Sales(Game game, User user)
        {
            Console.WriteLine(game.GameName+" "+game.GamePrice+" TL'ye satın alındı.");
        }
    }
}
