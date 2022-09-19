using System;
using System.Collections.Generic;
using RestSharp;

namespace ApiTesting.Utils
{
    public static class ApiUtils
    {
        private static readonly ConfigDataField url = ConfigUtils.ConfigDataFile();
        public static RestResponse SendGetRequest(string req)
        {
            RestClient client = new RestClient(url.SourceUrl);
            RestRequest request = new RestRequest(req, Method.Get);
            var responce = client.Execute(request);
            return responce;
        }

        public static RestResponse SendPostRequest(RestRequest request)
        {
            RestClient client = new RestClient(url.SourceUrl);
            var responce = client.Execute(request);
            return responce;
        }
    }
}
