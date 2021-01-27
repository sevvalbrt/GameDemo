using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GamerManager : IManagerService<Gamer>, IPersonCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationalityId != null && gamer.Name != null && gamer.LastName != null && gamer.DateOfBirth!=null)
            {
                Console.WriteLine(gamer.Name+" "+gamer.LastName + "\tApproved");
                return true;
            }
            else
            {
                Console.WriteLine("Person not found");
                return false;
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted gamer:" + gamer.Name+" "+ gamer.LastName);
        }

        public void Save(Gamer gamer)
        {
            Console.WriteLine("Added gamer:" + gamer.Name + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated gamer:" + gamer.Name + " " + gamer.LastName);
        }
    }
}
