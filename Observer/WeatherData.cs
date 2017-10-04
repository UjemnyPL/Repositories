using System;
using System.Collections;
namespace Observer
{
    public class WeatherData : ISubject
    {
        private ArrayList _observers;
        private float _temp;
        private float _hum;
        private float _press;

        public WeatherData()
        {
            _observers = new ArrayList();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int index = _observers.IndexOf(o);
            if (index >= 0)
            {
                _observers.RemoveAt(index);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver item in _observers)
            {
                item.Update(_temp, _hum, _press);
            };
        }
        public void ChangeReadings()
        {
            NotifyObservers();
        }

        public void SetReadings(float temp, float hum, float press)
        {
            _press = press;
            _temp = temp;
            _hum = hum;
            ChangeReadings();
        }
    }
}
