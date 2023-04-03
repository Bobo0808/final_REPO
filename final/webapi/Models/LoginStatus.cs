using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class LoginStatus
    {
        [Key]
        public int L_id { get; set; }
        [ForeignKey("Account")]
        public int A_id { get; set; }
        public DateTime L_cTime { get; set; }
        public DateTime L_dcTime { get; set; }
    }
}
