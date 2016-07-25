using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Corgr_Client.Models;

namespace Corgr_Client.Services
{
    public class DogsInTheSkyService : IDogsInTheSkyService
    {
        public DogModel GetRandomDog()
        {
            return new DogModel();
        }
    }
}