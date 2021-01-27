using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class Gamer:IEntity
    {
        public string NationalityId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
