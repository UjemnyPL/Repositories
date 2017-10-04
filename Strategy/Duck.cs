using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
 
    public abstract class Duck
    {
        public IFlying _flyingInterface;
        public IQuack _quackInterface;

        public Duck() { }

        public void ExecuteFly() {
            _flyingInterface.Fly();
        }

        public void ExecuteQuack()
        {
            _quackInterface.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Wszystkie kaczki pływają nawet te sztuczne");
        }

        public void SetFlyInterface(IFlying fi)
        {
            _flyingInterface = fi;
        }

        public void SetQuackInterface(IQuack qi)
        {
            _quackInterface = qi;
        }

        public abstract void Display();
    }
}
