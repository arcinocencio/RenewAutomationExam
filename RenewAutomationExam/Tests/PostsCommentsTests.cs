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
    public class PostsCommentsTests
    {
        private readonly RestClient restClient = new RestClient();

        [TestMethod]
        [Description("GET https://jsonplaceholder.typicode.com/posts/comments?postId=1")]
        public void VerifyPostCommentsDetails()
        {
            // Arrange
            var postId = 1;
            var commentId = 1;
            var request = new RestRequest(Endpoints.GetPostCommentById(postId, commentId));

            // Action
            var response = restClient.Get<List<PostsComment>>(request);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("Eliseo@gardner.biz", response.Data[0].email, $"Email should be matched to Eliseo@gardner.biz");
        }
    }
}
