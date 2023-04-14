using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class DebugLog
    {
        [Key]
        public int D_ID { get; set; }
        [ForeignKey("Account")]
        public int A_ID { get; set; }
        public Account? Account { get; set; }
        public DateTime D_time { get; set; }
        public string? D_event { get; set; }
        public bool D_isSolved { get; set; }





    }
}
