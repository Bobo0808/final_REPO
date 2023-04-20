using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Map_ADArea
    {
        [Key]
        public int Area_ID { get; set; } = default!;
        [ForeignKey("Map")]
        public int M_ID { get; set; } = default!;
        public Map Map { get; set; } = default!;
        [ForeignKey("CaseTable")]
        public int CaseID { get; set; } = default!;
        public CaseTable CaseTable { get; set; } = default!;
        public int Area_StartX { get; set; } = default!;
        public int Area_EndX { get; set; } = default!;
        public int Area_StartY { get; set; } = default!;
        public int Area_EndY { get; set; } = default!;
    }
}
