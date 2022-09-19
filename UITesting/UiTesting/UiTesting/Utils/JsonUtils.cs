using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace UiTesting.Utils
{
    class JsonUtils
    {
    }
    public partial class Fields
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("imagePath")]
        public string ImagePath { get; set; }

    }

    public partial class Fields
    {
        public static Fields FromJson(string json) => JsonConvert.DeserializeObject<Fields>(json, Serialize.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Fields self) => JsonConvert.SerializeObject(self, Serialize.Settings);
        
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
