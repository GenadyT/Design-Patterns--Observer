using FileContentChangeObserver.BL.Subject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileContentChangeObserver.UI
{
    internal partial class SunBather : FanOfTheSea
    {
        internal SunBather(ISubject subject) : base("Sun Bather", "sunbather", subject) { }

        public override void DisplayMood()
        {            
            string mood = String.Empty;
            
            if (weather.SkyCondition == SkyCondition.Sunny)
            {
                mood = Mood.Satisfied;                
            }
            else if (weather.SkyCondition == SkyCondition.Cloudy)
            {
                mood = Mood.Sad;
            }

            DisplayMoodImage(mood);
        }
    }
}
