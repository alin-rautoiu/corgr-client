using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Corgr_Client.Models;
using Newtonsoft.Json;
using System.Net;

namespace Corgr_Client.Services
{
    public class DogsInTheSkyService : IDogsInTheSkyService
    {
        public DogModel GetRandomDog()
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://corgr.herokuapp.com/getRandomCorgi");
            dynamic randomDog = JsonConvert.DeserializeObject<DogModel>(json);            
            
            return randomDog;
        }
    }
}