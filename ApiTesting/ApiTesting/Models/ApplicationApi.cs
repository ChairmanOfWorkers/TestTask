using System;
using System.Collections.Generic;
using System.Text;
using ApiTesting.Utils;
using RestSharp;

namespace ApiTesting.Models
{
    public class ApplicationApi
    {
        public static RestResponse GetPosts()
        {
            return ApiUtils.SendGetRequest("/posts");
        }

        public static RestResponse GetPostByID(string id)
        {
            return ApiUtils.SendGetRequest($"/posts/{id}");
        }

        public static RestResponse GetUsers()
        {
            return ApiUtils.SendGetRequest("/users");
        }

        public static RestResponse GetUserById(string id)
        {
            return ApiUtils.SendGetRequest($"/users/{id}");
        }

        public static RestResponse PostWithParams(RestRequest request)
        {
            return ApiUtils.SendPostRequest(request);
        }
    }
}
