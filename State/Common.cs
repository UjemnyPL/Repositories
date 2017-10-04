using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Common
    {
    }

    public enum VendingMachineStates
    {
        NoGum = 0,
        NoCoins,
        HaveCoins,
        GumSold
    }
}
