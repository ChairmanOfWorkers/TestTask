using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Newtonsoft.Json;

namespace ApiTesting.Models
{
    public static class ApiJsonReader
    {
        public static T ReadApiJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
