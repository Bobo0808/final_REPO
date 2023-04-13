using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Ads_Item
    {
        [Key]
        public int Ads_ItemID { get; set; }
        public string? Name { get; set; }
        public int? PartnerID { get; set; }
        public string? Desc { get; set; }
        public DateTime? Start_Time { get; set; }
        public DateTime? End_Time { get; set; }

    }
}
