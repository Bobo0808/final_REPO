using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class DebugLog
    {
        [Key]
        public int D_ID { get; set; } = default!;
        [ForeignKey("Account")]
        public int A_ID { get; set; } = default!;
        public UserAccount Account { get; set; } = default!;
        
        public DateTime D_time { get; set; } = default!;
        public string D_event { get; set; } = default!;
        public bool D_isSolved { get; set; } = default!;

        [MaxLength(100)]
        public string? D_Comment { get; set; }



    }
}
