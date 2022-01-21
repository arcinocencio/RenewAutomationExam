using Microsoft.VisualStudio.TestTools.UnitTesting;
using RenewAutomationExam.DataModels;
using RenewAutomationExam.Resources;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RenewAutomationExam.Tests
{
    [TestClass]
    public class PostsDetailsTests
    {
        private readonly RestClient restClient = new RestClient();

        [TestMethod]
        [Description("GET https://jsonplaceholder.typicode.com/posts/1")]
        public void VerifyPostDetailsById()
        {
            // Arrange
            var id = 1;
            var request = new RestRequest(Endpoints.GetPostById(id));

            // Action
            var response = restClient.Get<Posts>(request);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto", response.Data.body, $"Body content should be matched");

        }

        [TestMethod]
        [Description("GET https://jsonplaceholder.typicode.com/posts/1")]
        public void VerifyPostReturn404()
        {
            // Arrange
            var id = 9999;
            var request = new RestRequest(Endpoints.GetPostById(id));

            // Action
            var response = restClient.Get<Posts>(request);

            // Assert
            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
