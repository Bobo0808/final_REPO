using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Map_BlockedSpaces
    {
        [Key]
        public int MB_id { get; set; }
        [ForeignKey("Map")]
        public int M_id { get; set; }
        public int MB_startX { get; set; }
        public int MB_startY { get; set; }
        public int MB_endX { get; set; }
        public int MB_endY { get; set; }
    }
}
