using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class VendingMachine
    {
        IState NoGumState;
        IState NoCoinState;
        IState HaveCoinState;
        IState GumSoldState;

        IState state = new NoGumState();
        int _gumCount = 0;

        public VendingMachine(int gumCount)
        {
            NoGumState = new NoGumState(this);
            NoCoinState = new NoCoinState(this);
            HaveCoinState = new HaveCoinState(this);
            GumSoldState = new GumSoldState(this);

            _gumCount = gumCount;
            if(_gumCount > 0)
            {
                state = NoGumState;
            }
        }

        public void PutCoin()
        {
            state.PutCoin();
        }

        public void ReturnCoin()
        {
            state.ReturnCoin();
        }

        public void TurnKnob()
        {
            state.TurnKnob();
            state.MakeCoin();
        }

        void SetState(IState newState)
        {
            state = newState;
        }

        void ReleaseGum()
        {
            Console.WriteLine("Wypada guma");
            if(_gumCount != 0)
            {
                _gumCount -= 1;
            }
        }
    }
}
