using System;
using System.IO;
using Newtonsoft.Json;
using ApiTesting.Models;

namespace ApiTesting.Utils
{
    public static class TestDataUtils
    {
        private static readonly string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\Resource\\testData.json";
        public static UserData TestDataFile()
        {
            return JsonConvert.DeserializeObject<UserData>(File.ReadAllText(path));
        }
    }
}
