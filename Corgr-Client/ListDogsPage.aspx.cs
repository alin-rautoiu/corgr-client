using Corgr_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Corgr_Client
{
    public partial class ListDogsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DogModel> dogsLiked = LikedDogsList();
            RepeaterLikedDogs.DataSource = dogsLiked;
            RepeaterLikedDogs.DataBind();

            List<DogModel> dogsUnliked = UnlikedDogsList();
            RepeaterUnlikedDogs.DataSource = dogsUnliked;
            RepeaterUnlikedDogs.DataBind();

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