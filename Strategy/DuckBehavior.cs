using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DontFly : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Nie umiem latać!!!");

        }
    }

    public class FlyHaveWings : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Umiem latać bo mam skrzydła");
        }
    }

    /// <summary>
    /// Lot z napędem rakietowym
    /// </summary>
    public class FlyRocketPrupulsion: IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Uuuuuua! Lot z napędem akietowym!");
        }
    }

    public class Quack : IQuack
    {
        void IQuack.Quack()
        {
            Console.WriteLine("Kwa! Kwa!");
        }
    }

    //piszczeć
    public class Squeal : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Piszcze!");
        }
    }

    public class DontQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Cisza");
        }
    }
}
