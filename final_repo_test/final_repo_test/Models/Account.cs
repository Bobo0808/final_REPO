using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Account
    {
        [Key]
        public int A_ID { get; set; }
        public string A_Name { get; set; }
        public string UserName { get; set; }
        public string UserPWD { get; set; }
        public int? A_Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public int? A_level { get; set; }
        public string A_Email { get; set; }
        public string? A_Phone { get; set; }
        public string? A_add { get; set; }
        public DateTime A_RegisteredAt { get; set; }
    }
}
