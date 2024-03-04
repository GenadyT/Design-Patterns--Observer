using FileContentChangeObserver.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContentChangeObserver.BL.Subject
{
    // -- Subject ---
    internal class ForecastNotifier : ISubject
    {
        private List<FanOfTheSea> observers;
        private SeaWeather seaWeather;

        internal ForecastNotifier()
        {
            observers = new List<FanOfTheSea>();
        }

        //-----------------------------------------------
        public void RegisterObserver(FanOfTheSea observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(FanOfTheSea observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (FanOfTheSea o in observers)
            {
                o.Update(seaWeather);
            }
        }
        //-----------------------------------------------

        internal void MeasurementsChanged()

        {
            NotifyObservers();
        }

        internal void SetMeasurements(SeaWeather seaWeather)
        {
            this.seaWeather = seaWeather;
            MeasurementsChanged();
        }
    }
}
