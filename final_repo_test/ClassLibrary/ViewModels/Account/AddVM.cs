using ClassLibrary.Enum;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace ClassLibrary.ViewModels.Account
{
    public class AddVM
    {
        public int A_ID { get; set; } = default!;
        [Required(ErrorMessage = "姓名不可為空")]
        public string A_Name { get; set; } = default!;
        [Required(ErrorMessage = "使用者名稱不可為空")]
        public string UserName { get; set; } = default!;
        [Required(ErrorMessage = "請輸入密碼")]
        public string UserPWD { get; set; } = default!;
        [Required(ErrorMessage = "性別不可為空")]
        [EnumDataType(typeof(Gender), ErrorMessage = "Invalid Gender value")]
        public Gender A_Gender { get; set; }
        public int P_id { get; set; } = default!;
        public Product Product { get; set; } = default!;
        public DateTime Birthday { get; set; } = default!;
        public int A_level { get; set; } = default!;
        [Required(ErrorMessage = "信箱不可為空")]
        [EmailAddress(ErrorMessage = "信箱格式有誤")]
        public string A_Email { get; set; } = default!;
        [Required(ErrorMessage = "請輸入手機號碼")]
        [RegularExpression(@"^09\d{8}$", ErrorMessage = "手機格式必須為09開頭的10位數字")]
        [StringLength(10, ErrorMessage = "手機號碼不能超過10個字元")]
        public string A_Phone { get; set; } = default!;
        [Required(ErrorMessage = "地址不可為空")]
        public string A_add { get; set; } = default!;
        public DateTime A_RegisteredAt { get; set; } = default!;
        [Required(ErrorMessage = "暱稱不可為空")]
        public string A_NickName { get; set; } = default!;
        public int A_Coin { get; set; } = default!;
    }
}
