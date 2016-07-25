using Corgr_Client.Models;
using Corgr_Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Corgr_Client
{
    public partial class _Default : Page
    {
        public IDogsInTheSkyService dogsIntheSkyService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var Dog1 = dogsIntheSkyService.GetRandomDog();
            Dog1.Face = "labrador_image";
            Dog1.Name = "Aria";
            var Likes = new List<string>() { "Food" };
            Dog1.Likes = Likes;

            RepeaterLikes.DataSource = Likes;
            RepeaterLikes.DataBind();
        }
    }
}