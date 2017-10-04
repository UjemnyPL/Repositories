using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Display
    {
        public abstract void Update(float temp, float humidity, float pressure);
    }
}
