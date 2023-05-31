using System.ComponentModel.DataAnnotations;
using ClassLibrary.Enum;

namespace ChickenLife.Models.Account
{
    public class UserRegisterRequest
    {
        //[Required]
        //public string UserName { get; set; }

        [Required(ErrorMessage = "請輸入Email")]
        [EmailAddress(ErrorMessage = "無效的Email格式")]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "請輸入至少六位，老兄!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public Gender Gender { get; set; } = default!;

        //public string? Phone { get; set; }

        //public string? add { get; set; }

        public string? NickName { get; set; }

        //public string Name { get; set; } 
        //public string UserName { get; set; } = "admin";







    }
}
