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
            using (var client = new WebClient())
            {
                string json = client.DownloadString("https://corgr.herokuapp.com/getRandomCorgi");
                dynamic randomDog = JsonConvert.DeserializeObject<DogModel>(json);
                return randomDog;
            }
        }

        public List<string> Likes(int idDog)
        {
            List<string> likesList = new List<string>();
            using (var client = new WebClient())
            {
                string json = client.DownloadString($"https://corgr.herokuapp.com/getCorgi/{idDog}");

                return likesList;
            }
        }

        public DogModel GetDogById(int IdDog)
        {
            using (var client = new WebClient())
            {
                string json = client.DownloadString($"https://corgr.herokuapp.com/getCorgi/{IdDog}");
                var DogById = JsonConvert.DeserializeObject<DogModel>(json);

                return DogById;
            }
        }

        public IEnumerable<string> GetDogLikesById(int IdDog)
        {
            return GetDogById(IdDog).Likes;
        }

        public void AddLikedDog(DogModel DogLiked)
        {
            NewMethod(DogLiked, true);
        }

        private static void NewMethod(DogModel DogLiked, bool Appreciation)
        {
            using (var context = new DogContext.DogContext())
            {
                var newDog = new DogModel
                {
                    Index = DogLiked.Index,
                    Face = DogLiked.Face,
                    Name = DogLiked.Name,
                    Likes = DogLiked.Likes,
                    Liked = Appreciation
                };

                try
                {
                    context.DogModel.Add(newDog);
                    context.SaveChanges();
                }
                catch
                {

                }
            }
        }

        public void AddUnlikedDog(DogModel DogUnliked)
        {
            NewMethod(DogUnliked, false);
        }

       
    }
}