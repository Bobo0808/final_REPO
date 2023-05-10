using System.ComponentModel.DataAnnotations;
using ClassLibrary.Enum;
using ClassLibrary.Models;

namespace final_repo_test.ViewModels.Login
{
    public class LoginViewModel
    {

        public string E_Email { get; set; } = default!;
        public string E_Pwd { get; set; } = default!;
        public bool KeepLoggedIn { get; set;}
    }
}
