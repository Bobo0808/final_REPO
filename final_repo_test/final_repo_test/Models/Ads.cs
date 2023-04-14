using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Ads
    {
        [Key]
        public int Ad_ID { get; set; }
        [ForeignKey("Partner")]
        public int PartnerID { get; set; }
        public Partner Partner { get; set; }
        [ForeignKey("CaseTable")]
        public int CaseID { get; set; }
        public CaseTable CaseTable { get; set; }
        public DateTime Ad_StartTime { get; set; }
        public DateTime Ad_EndTime { get; set; }
        public int  Ad_DayCount { get; set; }
        public string? Ad_ImageURL { get; set; }
        public string? Ad_TargetURL { get; set; }
        public int Ad_Clicks { get; set; }
        public string? Ad_Description { get; set; }
    }
}
