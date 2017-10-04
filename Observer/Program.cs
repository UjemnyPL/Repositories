using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();
            data.ChangeReadings();
            Console.ReadLine();
        }
    }
}
