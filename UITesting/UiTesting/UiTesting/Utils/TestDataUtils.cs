using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UiTesting.Utils
{
    public static class TestDataUtils
    {
        public static Fields JsonReader()
        { 
            String jsonString = new StreamReader(FilePath()).ReadToEnd();
            var jsonFile = Fields.FromJson(jsonString);
            return jsonFile;
        }

        public static string FilePath()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            string path = $"{domain.BaseDirectory}\\Resources\\testData.json";

            return path;
        }
    }
}

