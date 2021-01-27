using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
