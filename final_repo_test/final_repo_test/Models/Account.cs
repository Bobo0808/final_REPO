using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Account
    {
        [Key]
        public int A_ID { get; set; }
        public string? A_Name { get; set; }
        public string? UserName { get; set; }
        public string? UserPWD { get; set; }
        public int? A_Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public int? A_level { get; set; }
        public string? A_Email { get; set; }
        public string? A_Phone { get; set; }
        public string? A_add { get; set; }
        public DateTime A_RegisteredAt { get; set; }
        public string? A_NickName { get; set; }
        public int A_Coin { get; set; }

        public ICollection<Order>? Orders { get; set; }
        [NotMapped]
        public ICollection<Report>? Reports { get; set; }
        [NotMapped]
        public ICollection<Society>? Societies { get; set; }
        public ICollection<DebugLog>? DebugLogs { get; set; }
        public ICollection<LoginStaus>? LoginStaus { get; set; }

    }
}
