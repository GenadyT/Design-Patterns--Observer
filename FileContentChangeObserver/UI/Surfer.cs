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
    internal partial class Surfer : FanOfTheSea
    {
        public Surfer(ISubject subject) : base("Surfer", "surfer", subject) { }

        public override void DisplayMood()
        {
            string mood = String.Empty;

            if (weather.SignificantHeight == SignificantHeight.High)
            {
                mood = Mood.Satisfied;
            }
            else if (weather.SignificantHeight == SignificantHeight.Low)
            {
                mood = Mood.Sad;
            }

            DisplayMoodImage(mood);
        }
    }
}
