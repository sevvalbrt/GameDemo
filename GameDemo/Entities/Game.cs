using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }
}
