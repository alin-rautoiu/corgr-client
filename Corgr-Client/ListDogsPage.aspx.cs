using Corgr_Client.Models;
using Corgr_Client.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Corgr_Client
{
    public partial class ListDogsPage : System.Web.UI.Page
    {

        public IDogsInTheSkyService dogsIntheSkyService { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DogModel> dogsLiked = LikedDogsList();
            RepeaterLikedDogs.DataSource = dogsLiked;
            RepeaterLikedDogs.DataBind();
       

            List<DogModel> dogsUnliked = UnlikedDogsList();
            RepeaterUnlikedDogs.DataSource = dogsUnliked;          
            RepeaterUnlikedDogs.DataBind();

        }

        protected void Dogs_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            var item = e.Item.DataItem as DogModel;
            
            Repeater DogListLikeRepeater = (Repeater)(e.Item.FindControl("RepeaterLikesList"));
            List<string > DogsLikes= dogsIntheSkyService.GetDogLikesById(item.Index) as List<string>;
            DogListLikeRepeater.DataSource = DogsLikes;
            DogListLikeRepeater.DataBind();
        }

        public List<DogModel> LikedDogsList()
        {

            using (var context = new DogContext.DogContext())
            {
                var dogsLiked = context.DogModel.Where(x => x.Liked == false).ToList();
                return dogsLiked;
            }
            
        }
        public List<DogModel> UnlikedDogsList()
        {

            using (var context = new DogContext.DogContext())
            {
                var dogsUnliked = context.DogModel.Where(x => x.Liked == true).ToList();
                return dogsUnliked;
            }

        }
    }
}