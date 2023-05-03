using final_repo_test.Data.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Employee
    {
        [Key]
        public int E_ID { get; set; } = default!;
        public string E_Name { get; set; } = default!;

        //public string E_Gender { get; set; }
        //public Gender E_Gender { get; set; } = default!;

        public enum Gender
        {
            男,
            女,
            其他
        }
        [Required(ErrorMessage = "Gender is required")]
        [EnumDataType(typeof(Gender), ErrorMessage = "Invalid Gender value")]
        public Gender E_Gender { get; set; }

        public string E_UserName { get; set; } = default!;
        public string E_Pwd { get; set; } = default!;
        public string E_Email { get; set; } = default!;
        //public Title E_Title { get; set; } = default!;
        public enum Title
        {
            員工,
            主管
        }
        [Required(ErrorMessage = "Title is required")]
        [EnumDataType(typeof(Title), ErrorMessage = "Invalid Title value")]
        public Title E_Title { get; set; }
        public string E_Phone { get; set; } = default!;
        [Column(TypeName = "Date")]
        public DateTime E_Birthday { get; set; } = default!;
        [Column(TypeName = "Date")]
        public DateTime E_HireDate { get; set; } = default!;
        public string E_Address { get; set; } = default!;
        public int E_Permission { get; set; } = default!;
        public bool E_Work { get; set; } = default!;
    }
}
