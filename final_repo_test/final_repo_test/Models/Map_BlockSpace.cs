using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Map_BlockSpace
    {
        [Key]
        public int Mb_ID { get; set; }
        [ForeignKey("Map")]
        public int M_ID { get; set; }
        public Map Map { get; set; }
        public int Mb_starX { get; set; }
        public int Mb_starY { get; set; }
        public int Mb_EndX { get; set; }
        public int Mb_EndY { get; set; }
    }
}
