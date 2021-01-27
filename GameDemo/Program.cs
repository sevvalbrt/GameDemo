using GameDemo.Abstract;
using GameDemo.Concrete;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                NationalityId = "11111111111",
                Name = "Şevval",
                LastName = "Barut",
                DateOfBirth = new DateTime(1111, 1, 1)
            };

            Gamer gamer2 = new Gamer()
            {
                NationalityId = "22222222222",
                Name = "Meral",
                LastName = "Taşdemir",
                DateOfBirth = new DateTime(2222, 2, 2)
            };

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                Name = "Big Sale"
            };

            GamerManager gamerManager = new GamerManager();
            gamerManager.Save(gamer1);
            gamerManager.Save(gamer2);
            gamerManager.CheckIfRealPerson(gamer1);
            gamerManager.CheckIfRealPerson(gamer2);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(campaign1);

            Game game1 = new Game()
            {
                Id = 1,
                Name = "Car Race"
            };

            ISalesService salesService = new SalesManager();
            salesService.Sale(gamer1, game1);
            Console.ReadLine();

        }
    }
}
