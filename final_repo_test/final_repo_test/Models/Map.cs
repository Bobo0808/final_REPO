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
        public ICollection<Map_BlockSpace>? Map_BlockSpaces { get; set; }
        public ICollection<Map_ADArea> Map_ADAreas { get; set; }
    }
}
