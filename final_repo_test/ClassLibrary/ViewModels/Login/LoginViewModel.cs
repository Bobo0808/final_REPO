using System.ComponentModel.DataAnnotations;
using ClassLibrary.Enum;
using ClassLibrary.Models;

namespace ClassLibrary.ViewModels.Login
{
    public class LoginViewModel
    {
        public string E_Email { get; set; }
        public string E_Pwd { get; set; }

        public bool KeepLoggedIn { get; set; }
    }
}
