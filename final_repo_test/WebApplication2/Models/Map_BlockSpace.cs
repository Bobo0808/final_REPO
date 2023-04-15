using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Map_BlockSpace
    {
        [Key]
        public int Mb_ID { get; set; } = default!;
        [ForeignKey("Map")]
        public int M_ID { get; set; } = default!;
        public Map Map { get; set; } = default!;
        public int Mb_starX { get; set; } = default!;
        public int Mb_starY { get; set; } = default!;
        public int Mb_EndX { get; set; } = default!;
        public int Mb_EndY { get; set; } = default!;
    }
}
