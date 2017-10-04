using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IFlying
    {
        void Fly();
    }

    public interface IQuack
    {
        void Quack();
    }
}
