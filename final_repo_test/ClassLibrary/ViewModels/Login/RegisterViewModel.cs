using System.ComponentModel.DataAnnotations;
using ClassLibrary.Enum;
using ClassLibrary.Models;

namespace ClassLibrary.ViewModels.Login
{
    public class RegisterViewModel
    {

        
        public string E_Email { get; set; }

        //[DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password can be min 6 characters.")]
        [MaxLength(16, ErrorMessage = "Password can be max 16 characters.")]
        public string E_Pwd { get; set; }

        [Required(ErrorMessage = "Re-Password is required.")]
        [MinLength(6, ErrorMessage = "Re-Password can be min 6 characters.")]
        [MaxLength(16, ErrorMessage = "Re-Password can be max 16 characters.")]
        [Compare(nameof(E_Pwd))]
        public string RePassword { get; set; }
    }
}
