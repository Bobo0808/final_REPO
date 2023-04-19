using final_repo_test.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Report
    {
        [Key]
        public int R_ID { get; set; } = default!;
        [ForeignKey("ReportAccount")]
        public int A_ID { get; set; } = default!;
        public UserAccount Account { get; set; } = default!;
        [ForeignKey("ReportedAccount")]
        public int ReportedA_ID { get; set; } = default!;
        public UserAccount ReportedAccount { get; set; } = default!;
        public DateTime R_Time { get; set; } = default!;
        public ReportType R_ReportType { get; set; } = default!;
        public string R_Reason { get; set; } = default!;
        public ReportStatus R_ReportStatus { get; set; } = default!;
        public string R_Reply { get; set; } = default!;
    }
}
