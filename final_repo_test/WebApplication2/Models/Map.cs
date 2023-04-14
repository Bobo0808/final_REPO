using final_repo_test.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Map
    {
        [Key]
        public int M_ID { get; set; } = default!;
        public string M_Desc { get; set; } = default!;
        public MapType M_MapType { get; set; } = default!;
        public string M_Src { get; set; } = default!;
        public int M_minX { get; set; } = default!;
        public int M_minY { get; set; } = default!;
        public int M_maxX { get; set; } = default!;
        public int M_maxY { get; set; } = default!;
        public ICollection<Map_BlockSpace>? Map_BlockSpaces { get; set; }
        public ICollection<Map_ADArea>? Map_ADAreas { get; set; }
    }
}
