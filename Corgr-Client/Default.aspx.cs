using Autofac;
using Autofac.Integration.Web;
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

        protected override void OnPreInit(EventArgs e)
        {
            var cpa = (IContainerProviderAccessor)HttpContext.Current.ApplicationInstance;
            var cp = cpa.ContainerProvider;
            cp.RequestLifetime.InjectProperties(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            dogsIntheSkyService = new DogsInTheSkyService();

            var Dog1 = dogsIntheSkyService.GetRandomDog();
          
            DogImage.ImageUrl = Dog1.Face;
            DogName.Text = Dog1.Name;
            RepeaterLikes.DataSource = Dog1.Likes;
            RepeaterLikes.DataBind();
        }
    }
}