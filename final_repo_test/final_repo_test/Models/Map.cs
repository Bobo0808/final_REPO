using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Map
    {
        [Key]
        public int M_ID { get; set; }
        public string? M_Desc { get; set; }
        public int M_Type { get; set; }
        public string? M_Src { get; set; }
        public int M_minX { get; set; }
        public int M_minY { get; set; }
        public int M_maxX { get; set; }
        public int M_maxY { get; set; }
    }
}
