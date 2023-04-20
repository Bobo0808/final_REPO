using System.ComponentModel.DataAnnotations;

namespace final_repo_test.ViewModels.Login
{
    public class LoginViewModel
    {
        [Display(Name ="Email Address")]
        [Required(ErrorMessage ="Email address is required")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PWD { get; set; }
    }
}
