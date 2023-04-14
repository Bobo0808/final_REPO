using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Map_UserCount
    {
        [Key]
        public int MU_ID { get; set; }
        public int M_ID { get; set; }
        public DateTime MU_time { get; set; }
        public int MU_count { get; set; }
    }
}
