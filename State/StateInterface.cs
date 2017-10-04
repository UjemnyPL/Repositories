using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    interface IState
    {
        //włóż monetę
        void PutCoin();
        //zwróć monetę
        void ReturnCoin();
        //przekręć gałkę
        void TurnKnob();
        //zwróć monetę
        void MakeCoin();
    }
}
