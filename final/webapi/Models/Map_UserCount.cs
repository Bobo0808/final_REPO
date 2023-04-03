using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Map_UserCount
    {
        [Key]
        public int MU_id { get; set; }
        [ForeignKey("Map")]
        public int M_id { get; set; }
        public DateTime MU_time { get; set; }
        public int MU_count { get; set; }
    }
}
