using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Ads_Locations
    {
        [Key]
        public int LocationID { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
    }
}
