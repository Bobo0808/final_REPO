using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Ads
    {
        [Key]
        public int Ad_ID { get; set; }
        public string? Ad_Name { get; set; }
        public string? Ad_Desc { get; set; }
        public int? Ads_ItemID { get; set; }
        public int? LocationID { get; set; }
        public string? ImageURL { get; set; }
        public string? TargetURL { get; set; }
        public int? Click { get; set; }




    }
}
