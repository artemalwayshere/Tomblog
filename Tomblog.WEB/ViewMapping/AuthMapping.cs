using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomblog.DAL.Model;
using Tomblog.WEB.ViewModels;

namespace Tomblog.WEB.ViewMapping
{
    public class AuthMapping
    {
        public static User MapRegisterViewModelToUserModel(RegisterViewModel model)
        {
            return new User()
            {
                Name = model.Name!,
                Email = model.Email!,
                Password = model.Password!
            };
        }
    }
}
