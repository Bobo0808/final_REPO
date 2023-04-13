using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class DebugLog
    {
        [Key]
        public int D_ID { get; set; }
        public int A_ID { get; set; }
        public DateTime D_time { get; set; }
        public string? D_event { get; set; }
        public bool D_isSolved { get; set; }





    }
}
