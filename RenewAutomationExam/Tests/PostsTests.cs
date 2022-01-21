using Microsoft.VisualStudio.TestTools.UnitTesting;
using RenewAutomationExam.DataModels;
using RenewAutomationExam.Resources;
using RestSharp;
using System.Collections.Generic;
using System.Net;

namespace RenewAutomationExam.Tests
{
    [TestClass]
    public class PostsTests
    {
        private readonly RestClient restClient = new RestClient();

        [TestMethod]
        [Description("GET https://jsonplaceholder.typicode.com/posts")]
        public void VerifyGetPostsDetails()
        {
            // Arrange
            var request = new RestRequest(Endpoints.GetPosts);

            // Action
            var response = restClient.Get<List<Posts>>(request);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.IsTrue(response.Data.Count > 0, $"Posts should not be less than 0");
        }
    }
}
