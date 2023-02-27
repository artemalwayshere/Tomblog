using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomblog.DAL.Model;

namespace Tomblog.Business.Services.Authentification
{
    public interface IAuthService
    {
        Task CreateUser(User userModel);
    }
}
