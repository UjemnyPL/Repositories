using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck dzika = new WildDuck();
            dzika.Display();
            dzika.ExecuteFly();
            dzika.ExecuteQuack();

            Duck model = new DuckModel();
            model.ExecuteFly();
            model.SetFlyInterface(new FlyRocketPrupulsion());
            model.ExecuteFly();

            Console.ReadKey();
        }
    }
}
