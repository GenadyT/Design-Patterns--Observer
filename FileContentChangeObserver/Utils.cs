using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileContentChangeObserver
{
    public class Utils
    {
        public static string DataFolderPath()
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data");
        }

        public static string DataFilePath(string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\" + fileName);
        }
    }
}
