using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class LoginStaus
    {
        [Key]
        public int L_ID { get; set; }
        public int? A_ID { get; set; }
        public DateTime L_cTime { get; set; }
        public DateTime L_dcTime { get; set; }
    }
}
