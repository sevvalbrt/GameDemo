using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSale(Campaign campaign, Gamer gamer, Game game)
        {
            Console.WriteLine("Gamer's Name: " + gamer.Name +" Game Name:" +game.Name+ "Campaign Name:" +campaign.Name);

        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine("Gamer's Name: " + gamer.Name +" "+gamer.LastName+ " Game Name:" + game.Name);
        }
    }
}
