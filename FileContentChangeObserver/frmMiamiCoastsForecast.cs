using System.IO;
using System.Reflection;
using FileContentChangeObserver.BL.Subject;
using FileContentChangeObserver.Properties;
using FileContentChangeObserver.UI;
using FileManager;

namespace FileContentChangeObserver
{
    public partial class frmMiamiCoastsForecast : Form
    {
        /*private FileSystemEventHandler onChangedHandlerd;
        private ErrorEventHandler onErrorHandler;*/

        private readonly string weatherDataFile = "Miami_coasts_forecast.json";
        private ForecastNotifier subject;

        public frmMiamiCoastsForecast()
        {
            InitializeComponent();

            string weatherFolderPath = Utils.DataFolderPath();
            InitDataWatcher(weatherFolderPath);

            DataEditorLoad();

            this.subject = new ForecastNotifier();
            ObserversInit(subject);
        }

        public void WatchTheCoastsForecast(object sender, FileSystemEventArgs e)
        {
            if (e.Name == this.weatherDataFile)
            {
                string filePath = Utils.DataFilePath(this.weatherDataFile);
                SeaWeather seaWeather = ObjectLoader.ReadJsonObjects<SeaWeather>(filePath);

                // Subject calls Observers Clear() method                 

                this.subject.SetMeasurements(seaWeather);
            }
        }

        public static void ClearTheCoastsForecast(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("the coasts weather is changed");
        }

        public static void WatchError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show("Error!!");

            // Subject calls Observers Clear() method 
        }

        public void InitDataWatcher(string folderPath)
        {
            FileWatcher fileWatcher = new FileWatcher(folderPath, "*.json",
                WatchTheCoastsForecast, WatchTheCoastsForecast,
                ClearTheCoastsForecast, WatchError, fileSystemWatcher1);

            fileWatcher.StartWatch();
        }

        private void ObserversInit(ISubject subject)
        {
            FanOfTheSea fan;
            const int X = 17;
            const int startY = 30;
            int nextY = startY;
            const int gapY = 20;

            fan = new Surfer(subject);
            fan.Location = new Point(X, nextY);
            gpbxFansOfTheSea.Controls.Add(fan);
            nextY += fan.Height + gapY;

            fan = new Swimmer(subject);
            fan.Location = new Point(X, nextY);
            gpbxFansOfTheSea.Controls.Add(fan);
            nextY += fan.Height + gapY;

            fan = new SunBather(subject);
            fan.Location = new Point(X, nextY);
            gpbxFansOfTheSea.Controls.Add(fan);
            nextY += fan.Height + gapY;

            gpbxFansOfTheSea.Height = nextY;
        }

        private void DataEditorLoad()
        {
            string fileText = File.ReadAllText(Utils.DataFilePath(weatherDataFile));
            tbxTextArea.Text = fileText;
        }

        private void btnUdateTextFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(Utils.DataFilePath(weatherDataFile)))
            {
                writer.Write(tbxTextArea.Text);
            }
        }
    }
}
