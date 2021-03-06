﻿using Corgr_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corgr_Client.Services
{
    public interface IDogsInTheSkyService
    {
        DogModel GetDogById(int IdDog);
        IEnumerable<string> GetDogLikesById(int IdDog);
        DogModel GetRandomDog();
        void AddLikedDog(DogModel DogLiked);
        void AddUnlikedDog(DogModel DogUnliked);
    }
}
