using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class WeatherCurrentConditions : Display
    {
        public override void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine("Temperatura: {0}; Wilgotność: {1}; Ciśnienie: {2}", temp, humidity, pressure);
        }
    }
}
