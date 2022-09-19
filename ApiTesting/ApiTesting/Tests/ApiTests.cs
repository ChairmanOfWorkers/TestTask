using NUnit.Framework;
using System.Net;
using System.Linq;
using ApiTesting.Models;
using ApiTesting.Utils;
using System.Collections.Generic;
using System.Data;
using System;
using RestSharp;

namespace ApiTesting.Tests
{
    public class ApiTests
    {
        [Test]
        public void TestCaseOne()
        {
            UserData testDataFile = TestDataUtils.TestDataFile();
            
            //step 1
            var getPostsResponse = ApplicationApi.GetPosts();
            List<SinglePostData> postsResponseData = ApiJsonReader.ReadApiJson<List<SinglePostData>>(getPostsResponse.Content);
            List<SinglePostData> sortedpostsResponseData = postsResponseData.OrderBy(o => o.UserId).ToList();

            Assert.AreEqual(getPostsResponse.StatusCode, HttpStatusCode.OK, "response status is NOT 200");
            Assert.AreEqual(getPostsResponse.ContentType, "application/json", "response is NOT in JSON format");
            Assert.AreEqual(postsResponseData, sortedpostsResponseData, "api response is NOT sorted");

            //step 2
            var getPostByIdResponse = ApplicationApi.GetPostByID("99");
            SinglePostData postByIdData = ApiJsonReader.ReadApiJson<SinglePostData>(getPostByIdResponse.Content);

            Assert.AreEqual(getPostByIdResponse.StatusCode, HttpStatusCode.OK, "response status is NOT 200");
            Assert.AreEqual(postByIdData.UserId, 10, "User Id is NOT 10");
            Assert.AreEqual(postByIdData.Id, 99, "Id is NOT 99");
            Assert.IsNotEmpty(postByIdData.Title, "Title field is empty");
            Assert.IsNotEmpty(postByIdData.Body, "Body field is empty");

            //step 3
            var nonExistingUserResponse = ApplicationApi.GetPostByID("150");

            Assert.AreEqual(nonExistingUserResponse.StatusCode, HttpStatusCode.NotFound, "response status is NOT 404");
            Assert.AreEqual(nonExistingUserResponse.Content, "{}", "response body is NOT empty");

            //step 4
            string title = RandomPostData.RandomString(6);
            string body = RandomPostData.RandomString(15);

            RestRequest request = new RestRequest("/posts", Method.Post);
            request.AddParameter("userId", 1);
            request.AddParameter("title", title);
            request.AddParameter("body", body);

            var postMethodResponse = ApplicationApi.PostWithParams(request);
            SinglePostData postResponseData = ApiJsonReader.ReadApiJson<SinglePostData>(postMethodResponse.Content);

            Assert.AreEqual(postMethodResponse.StatusCode, HttpStatusCode.Created, "response status is NOT 201");
            Assert.AreEqual(postResponseData.UserId, 1, "userId from response and one posted are NOT the same");
            Assert.AreEqual(postResponseData.Title, title, "title from response and one posted are NOT the same");
            Assert.AreEqual(postResponseData.Body, body, "body from response and one posted are NOT the same");
            Assert.IsNotNull(postResponseData.Id, "Id does NOT exist");

            //step 5
            var usersResponse = ApplicationApi.GetUsers();
            List<UserData> usersResponseData = ApiJsonReader.ReadApiJson<List<UserData>>(usersResponse.Content);

            Assert.AreEqual(usersResponse.StatusCode, HttpStatusCode.OK, "response status is NOT 200");
            Assert.AreEqual(usersResponse.ContentType, "application/json", "response is NOT in JSON format");
            Assert.IsTrue(Object.Equals(usersResponseData[4], testDataFile), "User data is different from what was expected");

            //step 6
            var userResponse = ApplicationApi.GetUserById("5");
            UserData userData = ApiJsonReader.ReadApiJson<UserData>(userResponse.Content);

            Assert.AreEqual(userResponse.StatusCode, HttpStatusCode.OK, "response status is NOT 200");
            Assert.AreEqual(userResponse.ContentType, "application/json", "response is NOT in JSON format");
            Assert.IsTrue(Object.Equals(userData, testDataFile), "User data is different from what was expected");
        }
    }
}