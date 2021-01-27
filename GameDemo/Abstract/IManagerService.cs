using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IManagerService<T>
    {
        void Save(T gamer);
        void Update(T gamer);
        void Delete(T gamer);
    }
}
