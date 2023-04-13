using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Character
    {
        [Key]
        public int C_ID { get; set; }
        public int? A_ID { get; set; }
        public string? C_Name { get; set; }
        public bool? C_Gender { get; set; }
        public DateTime? C_CreatedAt  { get; set; }
        public int? C_Apperance { get; set; }
        public int? C_Coin { get; set; }
    }
}
