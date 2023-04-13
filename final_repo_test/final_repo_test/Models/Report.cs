using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Report
    {
        [Key]
        public int ReportNo { get; set; }
        public int A_ID { get; set; }
        public int ReportedA_ID { get; set; }
        public DateTime R_Time { get; set; }
        public string?  R_Type { get; set; }
        public string? R_Reason { get; set; }
        public string? R_Status { get; set; }
        public string? reply { get; set; }
    }
}
