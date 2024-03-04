using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileContentChangeObserver
{
    internal class SeaWeather
    {
		private string significantHeight;
		public string SignificantHeight
        {
			get { return significantHeight; }
            set {  significantHeight = value; }
		}

        private string skyCondition;
        public string SkyCondition
        {
            get { return skyCondition; }
            set { skyCondition = value; }
        }

        public SeaWeather(string significantHeight, string skyCondition)
        {
            this.significantHeight = significantHeight;
            this.skyCondition = skyCondition;
        }
    }
}
