using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class DebugLog
    {
        [Key]
        public int D_id { get; set; }
        [ForeignKey("Account")]
        public int A_id { get; set; }
        public DateTime D_time { get; set; }
        public string D_event { get; set; }
        public bool D_isSolved { get; set; }
    }
}
