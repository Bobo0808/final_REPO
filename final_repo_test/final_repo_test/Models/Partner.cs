using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Partner
    {
        [Key]
        public int? P_ID { get; set; }
        public string? P_Name { get; set; }
        public string? Contact { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public ICollection<Ads> Ads { get; set; }
    }
}
