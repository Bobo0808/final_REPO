using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Society
    {
        [Key]
        public int S_ID { get; set; }
        public int? SA_ID { get; set; }
        
        public int? S_TargetID { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public string? Notes { get; set; }
    }
}
