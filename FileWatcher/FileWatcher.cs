using System.IO;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FileManager
{
    public class FileWatcher
    {
        private FileSystemEventHandler onCreated;
        private FileSystemEventHandler onChangedHandler;
        private FileSystemEventHandler onDeleted;
        private ErrorEventHandler onErrorHandler;
        private FileSystemWatcher fswWatcher;

        public FileWatcher(string folderPath, string filter,
            FileSystemEventHandler onCreated,
            FileSystemEventHandler onChangedHandler,
            FileSystemEventHandler onDeleted,
            ErrorEventHandler onErrorHandler, FileSystemWatcher watcher)
        {
            this.fswWatcher = watcher;
            WatcherInint(folderPath, filter, this.fswWatcher);

            this.onCreated = onCreated;
            this.onChangedHandler = onChangedHandler;
            this.onDeleted = onDeleted;
            this.onErrorHandler = onErrorHandler;
        }

        private void WatcherInint(string folderPath, string filter, FileSystemWatcher watcher)
        {
            this.fswWatcher = watcher;
            this.fswWatcher.Path = folderPath;
            this.fswWatcher.Filter = filter;

            fswWatcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            fswWatcher.IncludeSubdirectories = true;
            fswWatcher.EnableRaisingEvents = true;
        }

        public void StartWatch()
        {
            fswWatcher.Created += onCreated;
            fswWatcher.Changed += onChangedHandler;
            fswWatcher.Deleted += onDeleted;
            fswWatcher.Error += onErrorHandler;
        }
    }
}
