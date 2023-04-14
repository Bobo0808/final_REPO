using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Map_ADArea
    {
        [Key]
        public int Area_ID { get; set; }
        [ForeignKey("Map")]
        public int M_ID { get; set; }
        public Map Map { get; set; }
        [ForeignKey("CaseTable")]
        public int CaseID { get; set; }
        public CaseTable CaseTable { get; set; }
        public int Area_StartX { get; set; }
        public int Area_EndX { get; set; }
        public int Area_StartY { get; set; }
        public int Area_EndY { get; set; }
    }
}
