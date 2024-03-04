using System;
using System.Collections.Generic;
using System.Text;
using FileContentChangeObserver.UI;

namespace FileContentChangeObserver.BL.Subject
{
    interface ISubject
    {
        void RegisterObserver(FanOfTheSea observer);
        void RemoveObserver(FanOfTheSea observer);
        void NotifyObservers();
    }
}
