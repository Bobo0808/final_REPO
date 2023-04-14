using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Map_BlockSpaces
    {
        [Key]
        public int Mb_ID { get; set; }
        public int M_ID { get; set; }
        public int Mb_starX { get; set; }
        public int Mb_starY { get; set; }
        public int Mb_EndX { get; set; }
        public int Mb_EndY { get; set; }
    }
}
