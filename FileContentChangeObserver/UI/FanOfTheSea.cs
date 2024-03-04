using FileContentChangeObserver.BL.Subject;
using FileContentChangeObserver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileContentChangeObserver.BL;

namespace FileContentChangeObserver.UI
{
    // -- Observer ----
    internal abstract partial class FanOfTheSea : UserControl, IObserver, IDisplayElement
    {
        protected SeaWeather weather;

        protected ISubject forecastNotifier; 

        /*private string fanTypeTitle;
        public string FanTypeTitle
        {
            get { return fanTypeTitle; }
        }

        private string fanTypeImage;
        public string FanTypeImage
        {
            get { return fanTypeImage; }
        }*/

        /*private string fanMood;
        public string FanMood
        {
            get { return fanMood; }
            set { fanMood = value; }
        }*/

        internal FanOfTheSea(string fanTypeTitle, string fanTypeImage, ISubject forecastNotifier)
        { 
            InitializeComponent();            

            this.forecastNotifier = forecastNotifier;
            forecastNotifier.RegisterObserver(this);

            lblFanType.Text += $"'{fanTypeTitle}'";
            lblTheFanMoodTitle.Text = $"The '{fanTypeTitle}' mood is:"; 

            object picObj = Resources.ResourceManager.GetObject(fanTypeImage);
            pbxFanTypeImage.Image = (Image)picObj;
        }

        public void Update(SeaWeather weather)
        {
            this.weather = weather;
            DisplayMood();
        }

        protected void DisplayMoodImage(string mood)
        {
            object picObj = Resources.ResourceManager.GetObject(mood);
            pbxFanMoodImage.Image = (Image)picObj;
        }

        public abstract void DisplayMood();        

        internal void Clear()
        {
            pbxFanMoodImage.Image = null;
        }
    }
}
