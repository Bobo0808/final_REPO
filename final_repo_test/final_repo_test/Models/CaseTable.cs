using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class CaseTable
    {
        [Key]
        public int CaseID { get; set; }
        public string? CaseName { get; set; }
        public decimal PricePerDay { get; set; }
        public ICollection<Ads> Ads { get; set; }
        public ICollection<Map_ADArea> Map_ADAreas { get; set; }

    }
}
