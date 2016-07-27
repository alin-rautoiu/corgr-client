using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Corgr_Client.Models
{
    [Serializable]
    [Table("Dog", Schema = "Dg")]
    public class DogModel
    {   [Key]
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("pathToFace")]
        [MaxLength(150)]
        public string Face { get; set; }
        [JsonProperty("name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [JsonProperty("likes")]
        public IEnumerable<string> Likes { get; set; }
        public bool ? Liked { get; set; }
    }
}