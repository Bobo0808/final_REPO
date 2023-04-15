using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Ads
    {
        [Key]
        public int Ad_ID { get; set; } = default!;
        [ForeignKey("Partner")]
        public int PartnerID { get; set; } = default!;
        public Partner Partner { get; set; } = default!;
        [ForeignKey("CaseTable")]
        public int CaseID { get; set; } = default!;
        public CaseTable CaseTable { get; set; } = default!;
        [Column(TypeName = "Date")]
        public DateTime Ad_StartTime { get; set; } = default!;
        [Column(TypeName = "Date")]
        public DateTime Ad_EndTime { get; set; } = default!;
        public int  Ad_DayCount { get; set; } = default!;
        public string? Ad_ImageURL { get; set; } = default!;
        public string? Ad_TargetURL { get; set; } = default!;
        public int Ad_Clicks { get; set; } = default!;
        public string? Ad_Description { get; set; } = default!;
    }
}
