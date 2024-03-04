using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContentChangeObserver.BL
{
    internal interface IObserver
    {
        internal void Update(SeaWeather weather);
    }
}
