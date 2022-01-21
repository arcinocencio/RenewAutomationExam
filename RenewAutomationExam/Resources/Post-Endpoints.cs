using System;
using System.Collections.Generic;
using System.Text;

namespace RenewAutomationExam.Resources
{
    public class Endpoints
    {
        private const string BaseURL = "https://jsonplaceholder.typicode.com";

        public static string GetPosts = $"{BaseURL}/posts";
        public static string GetPostById(int id) => $"{GetPosts}/{id}";

        public static string GetPostCommentById(int postId, int commentId) => $"{GetPostById(postId)}/comments?id={commentId}";
    }
}
