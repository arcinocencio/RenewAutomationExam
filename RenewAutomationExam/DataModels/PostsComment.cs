using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewAutomationExam.DataModels
{
    public class PostsComment
    {
        [JsonProperty("postId")]
        public long postId { get; set; }

        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("body")]
        public string body { get; set; }
    }
}
