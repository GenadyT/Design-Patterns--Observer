using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json;

namespace FileManager
{
    public static class ObjectLoader
    {
        public static T ReadJsonObjects<T>(string path) where T : class
        {
            if (!File.Exists(path)) return null;

            T result;

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                result = JsonSerializer.Deserialize<T>(json);
            }

            return result;
        }


    }
}
