using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaignManager : IManagerService<Campaign>
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleted Campaign:" + campaign.Name);

        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine("Added Campaign:" + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Updated Campaign:" +campaign.Name);
        }
    }
}
