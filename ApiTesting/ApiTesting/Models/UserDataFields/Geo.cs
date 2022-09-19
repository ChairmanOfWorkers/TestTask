using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTesting.Models.UserDataFields
{
    public class Geo
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }
        [JsonProperty("lng")]
        public string Lng { get; set; }
    }
}
