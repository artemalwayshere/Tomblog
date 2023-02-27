using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tomblog.Business.Services.Authentification;
using Tomblog.WEB.ViewMapping;
using Tomblog.WEB.ViewModels;

namespace Tomblog.WEB.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly IAuthService _authService;
        public RegisterController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _authService.CreateUser(AuthMapping.MapRegisterViewModelToUserModel(model));
            }

            return Ok();
        }
    }
}
