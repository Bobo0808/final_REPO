using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Society
    {
        [Key]
        public int S_ID { get; set; }
        [ForeignKey("Account")]
        public int? A_ID { get; set; }
        public Account? Account { get; set; }
        [ForeignKey("Account")]
        public int? TargetA_ID { get; set; }
        public Account? TargetAccount { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? Notes { get; set; }
    }
}
