using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tomblog.Business.Services.Authentification.Security;
using Tomblog.DAL.Model;
using Tomblog.DAL.Repositories.Interfaces;

namespace Tomblog.Business.Services.Authentification
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepo;
        private readonly IEncrypt _encrypt;
        public AuthService(IAuthRepository authRepo, IEncrypt encrypt)
        {
            _authRepo = authRepo;
            _encrypt = encrypt;
        }

        public async Task CreateUser(User userModel)
        {
            if (_authRepo.GetUserByEmail(userModel.Email) != null)
            {
                throw new InvalidOperationException("Пользователь с таким Email уже зарегестрирован");
            }

            string emailAddress = userModel.Email;
            string pattern = @"^[A-Z0-9._%+-]+((@home\.co\.uk)|(@home\.com)|(@homegroup\.com))$";
            if (Regex.IsMatch(emailAddress, pattern, RegexOptions.IgnoreCase))
            {
                // email address is valid
            }

            userModel.Salt = Guid.NewGuid().ToString();
            userModel.Password = _encrypt.HashPassword(userModel.Password, userModel.Salt);
            await _authRepo.AddUserAsync(userModel);
            await _authRepo.SaveChangesAsync();
        }
    }
}
