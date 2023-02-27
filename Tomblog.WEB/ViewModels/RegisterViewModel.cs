using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomblog.WEB.ViewModels
{
    public class RegisterViewModel
    {
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "Введите корректный email адрес")]
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
