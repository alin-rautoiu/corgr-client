using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Corgr_Client.Models
{
    public class DogModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("pathToFace")]
        public string Face { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("likes")]
        public IEnumerable<string> Likes { get; set; }
    }
}