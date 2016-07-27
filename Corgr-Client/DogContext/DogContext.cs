using Corgr_Client.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Corgr_Client.DogContext
{
    public class DogContext : DbContext
    {

        public DogContext() : base("Dog")
        {
            Init();
        }
        private void Init()
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }
        public DbSet<DogModel> DogModel { get; set; }

    }
}