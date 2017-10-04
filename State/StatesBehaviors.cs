using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GumSoldState : IState
    {
        VendingMachine vm;

        public GumSoldState(VendingMachine vendingMachine)
        {
            vm = vendingMachine;
        }

        public void MakeCoin()
        {
            throw new NotImplementedException();
        }

        public void PutCoin()
        {
            throw new NotImplementedException();
        }

        public void ReturnCoin()
        {
            throw new NotImplementedException();
        }

        public void TurnKnob()
        {
            throw new NotImplementedException();
        }
    }

    public class NoGumState : IState
    {
        VendingMachine _vendingMachine;
        public NoGumState(VendingMachine vendingMachine)
        {
            _vendingMachine = vendingMachine;
        }

        public NoGumState() { }

        public void MakeCoin()
        {
            throw new NotImplementedException();
        }

        public void PutCoin()
        {
            throw new NotImplementedException();
        }

        public void ReturnCoin()
        {
            throw new NotImplementedException();
        }

        public void TurnKnob()
        {
            throw new NotImplementedException();
        }
    }

    public class NoCoinState : IState
    {
        VendingMachine _vendingMachine;

        public NoCoinState(VendingMachine vendingMachine){
            _vendingMachine = vendingMachine;
        }

        public void MakeCoin()
        {
            Console.WriteLine("Nie włożyłeś monety");
        }

        public void PutCoin()
        {
            Console.WriteLine("Moneta przyjęta");
            //_vendingMachine.SetState(_vendingMachine.GetHaveCoinState());
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Najpierw zapłać");
        }

        public void TurnKnob()
        {
            Console.WriteLine("Zanim przekręcisz gałkę wrzuć monetę");

        }
    }

    public class HaveCoinState : IState
    {
        VendingMachine vm;

        public HaveCoinState(VendingMachine vendingMachine)
        {
            vm = vendingMachine;
        }

        public void MakeCoin()
        {
            throw new NotImplementedException();
        }

        public void PutCoin()
        {
            throw new NotImplementedException();
        }

        public void ReturnCoin()
        {
            throw new NotImplementedException();
        }

        public void TurnKnob()
        {
            throw new NotImplementedException();
        }
    }
}
