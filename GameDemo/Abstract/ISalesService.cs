using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ISalesService
    {
        void Sale(Gamer gamer, Game game);
        void CampaignSale(Campaign campaign, Gamer gamer,Game game);
    }
}
