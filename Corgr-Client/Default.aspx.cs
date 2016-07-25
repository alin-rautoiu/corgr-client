using Corgr_Client.Models;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            var Dog1 = new DogModel();
            Dog1.Face = "labrador_image";
            Dog1.Name = "Aria";
            var Likes = new List<string>() { "Food" };
            Dog1.Likes = Likes;

            RepeaterLikes.DataSource = Likes;
            RepeaterLikes.DataBind();
        }
    }
}