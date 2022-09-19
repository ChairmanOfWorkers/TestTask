using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ApiTesting.Utils
{
    public static class ConfigUtils
    {        
        private static readonly string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\Resource\\configData.json";
        

        public static ConfigDataField ConfigDataFile()
        {
            return JsonConvert.DeserializeObject<ConfigDataField>(File.ReadAllText(path));
        }
    }

    public class ConfigDataField
    {
        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }
    }
}
