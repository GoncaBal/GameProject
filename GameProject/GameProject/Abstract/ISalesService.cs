using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sales(Game game, User user);
        void CampaignSales(Game game, User user,Campaign campaign);
    }
}
