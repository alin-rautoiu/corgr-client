using Corgr_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corgr_Client.Services
{
    public interface IDogsInTheSkyService
    {
        DogModel GetRandomDog();
    }
}
