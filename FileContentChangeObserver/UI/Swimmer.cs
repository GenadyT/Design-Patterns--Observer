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
    internal partial class Swimmer : FanOfTheSea
    {
        public Swimmer(ISubject subject) : base("Swimmer", "swimmer", subject) { } 

        public override void DisplayMood()
        {
            string mood = String.Empty;

            if (weather.SignificantHeight == SignificantHeight.High)
            {                
                mood = Mood.Sad;
            }
            else if (weather.SignificantHeight == SignificantHeight.Low)
            {
                mood = Mood.Satisfied;
            }

            DisplayMoodImage(mood);
        }
    }
}
