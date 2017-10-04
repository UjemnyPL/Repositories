using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Nowa kaczka
    /// </summary>
    public class DuckModel : Duck
    {
        public DuckModel()
        {
            _flyingInterface = new DontFly();
            _quackInterface = new DontQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Jestem modelem kaczki");
        }
    }
    /// <summary>
    /// Dzika Kaczka
    /// </summary>
    public class WildDuck : Duck
    {
        public WildDuck()
        {
            _flyingInterface = new FlyHaveWings();
            _quackInterface = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Jestem Dziką Kaczką");
        }
    }

    /// <summary>
    /// Płaskonosa kaczka
    /// </summary>
    class FlatfishDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Jestem Płaskonosą Kaczką");
        }
    }

    /// <summary>
    /// Gumowa kaczka
    /// </summary>
    class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Jestem Płaskonosą Kaczką");
        }
    }

    /// <summary>
    /// Wabik kaczka
    /// </summary>
    class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Jestem Płaskonosą Kaczką");
        }
    }
}
