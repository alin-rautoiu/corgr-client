using Autofac;
using Autofac.Integration.Web;
using Corgr_Client.Models;
using Corgr_Client.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Corgr_Client
{
    
    public partial class _Default : Page
    {
        DogModel Dog1;

        public IDogsInTheSkyService dogsIntheSkyService { get; set; }
        protected override void OnPreInit(EventArgs e)
        {
            var cpa = (IContainerProviderAccessor)HttpContext.Current.ApplicationInstance;
            var cp = cpa.ContainerProvider;
            cp.RequestLifetime.InjectProperties(this);
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateDog();
            } else {
                Dog1 = (DogModel)ViewState["Dog"];
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


        private void UpdateDog()
        {
            Dog1 = dogsIntheSkyService.GetRandomDog();
            ViewState["Dog"] = Dog1;

            using (var  context = new DogContext.DogContext())
            {
                NextButton.Style.Remove("display");

                if (!context.DogModel.Any(x => x.Index == Dog1.Index))
                {
                    NextButton.Style.Add("display", "none");
                    AddToPage(Dog1);

                }
                else
                {
                    LikeButton.Style.Add("display", "none");
                    DislikeButton.Style.Add("display", "none");


                    var appreciation = context.DogModel
                        .Single(x => x.Index == Dog1.Index).Liked.Value;

                    DogImage.Style.Remove("border-color");

                    if (appreciation)
                    {
                        DogImage.Style.Add(" border-color","palegreen");

                    }
                    else
                    {
                        DogImage.Style.Add(" border-color","red");
                    }

                    AddToPage(Dog1);

                }
            }
        }

        public void AddToPage(DogModel Dog)
        {
            DogImage.ImageUrl = Dog1.Face;
            DogName.Text = Dog1.Name;
            RepeaterLikes.DataSource = Dog1.Likes;
            RepeaterLikes.DataBind();
        }

        protected void DislikeButton_Click(object sender, EventArgs e)
        {
            dogsIntheSkyService = new DogsInTheSkyService();
            dogsIntheSkyService.AddUnlikedDog(Dog1);
            UpdateDog();
        }

        protected void LikeButton_Click(object sender, EventArgs e)
        {
            dogsIntheSkyService = new DogsInTheSkyService();
            dogsIntheSkyService.AddLikedDog(Dog1);
            UpdateDog();
        }
        protected void NextButton_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}