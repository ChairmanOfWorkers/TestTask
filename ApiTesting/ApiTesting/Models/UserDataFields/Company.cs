using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTesting.Models.UserDataFields
{
    public class Company
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("catchPhrase")]
        public string CatchPhrase { get; set; }
        [JsonProperty("bs")]
        public string Bs { get; set; }
    }
}
