using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Corgr_Client.Models
{
    public class DogModel
    {
        public string Face { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Likes { get; set; }
    }
}