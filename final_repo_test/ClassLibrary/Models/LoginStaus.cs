using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public class LoginStaus
    {
        [Key]
        public int L_ID { get; set; } = default!;
        [ForeignKey("Account")]
        public int A_ID { get; set; } = default!;
        public UserAccount Account { get; set; } = default!;
        public DateTime L_cTime { get; set; } = default!;
        public DateTime L_dcTime { get; set; } = default!;
    }
}
