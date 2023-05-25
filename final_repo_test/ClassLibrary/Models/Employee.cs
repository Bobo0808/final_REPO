using ClassLibrary.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public class Employee
    {
        [Key]
        public int E_ID { get; set; } = default!;
        [Required(ErrorMessage = "姓名不可為空")]
        public string E_Name { get; set; } = default!;
        //public string E_Gender { get; set; }
        //public Gender E_Gender { get; set; } = default!; 
        [Required(ErrorMessage = "性別不可為空")]
        [EnumDataType(typeof(Gender), ErrorMessage = "Invalid Gender value")]
        public Gender E_Gender { get; set; }

        [Required(ErrorMessage = "別名不可為空")]
        public string E_UserName { get; set; } = default!;

        [Required(ErrorMessage = "請輸入密碼")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$", ErrorMessage = "密碼長度必須為6字以上且須包含大小寫英文和數字")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "密碼長度必須為6字以上")]
        public string E_Pwd { get; set; } = default!;
        [Required(ErrorMessage = "信箱不可為空")]
        [EmailAddress(ErrorMessage = "信箱格式有誤")]
        public string E_Email { get; set; } = default!;
        //public Title E_Title { get; set; } = default!;
        
        [Required(ErrorMessage = "職位不可為空")]
        [EnumDataType(typeof(Title), ErrorMessage = "Invalid Title value")]
        public Title E_Title { get; set; }

        [Required(ErrorMessage = "請輸入手機號碼")]
        [RegularExpression(@"^09\d{8}$", ErrorMessage = "手機格式必須為09開頭的10位數字")]
        [StringLength(10, ErrorMessage = "手機號碼不能超過10個字元")]
        public string E_Phone { get; set; } = default!;

        [Column(TypeName = "Date")]
        [Required(ErrorMessage = "生日不可為空")]
        public DateTime E_Birthday { get; set; } = default!;

        [Column(TypeName = "Date")]
        [Required(ErrorMessage = "就職日不可為空")]
        public DateTime E_HireDate { get; set; } = default!;

        [Required(ErrorMessage = "地址不可為空")]
        public string E_Address { get; set; } = default!;

        [Required(ErrorMessage = "權限不可為空")]
        public int E_Permission { get; set; } = default!;

        public bool E_Work { get; set; } = default!;

        public bool Locked { get; set; } = false;
        //public bool KeepLoggedIn { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; } = "user";
        public enum Gender
        {
            男,
            女,
            其他
        }
        public enum Title
        {
            員工,
            主管
        }
        //public string E_Gender { get; set; }
        //public Gender E_Gender { get; set; } = default!;
        //public Title E_Title { get; set; }
    }
}
