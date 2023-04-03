using System.ComponentModel.DataAnnotations;
using webapi.Data.Enum;

namespace webapi.Models
{
    public class Map
    {
        [Key]
        public int M_id { get; set; }
        public string M_desc { get; set; }
        public M_type M_type { get; set; }
        public string M_src { get; set; }
        public int M_minX { get; set;}
        public int M_minY { get; set;}
        public int M_maxX { get; set;}
        public int M_maxY { get; set;}
    }
}
