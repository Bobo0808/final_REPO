using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Models
{
    public class CaseTable
    {
        [Key]
        public int Case_ID { get; set; } = default!;
        public string Case_Name { get; set; } = default!;

        public string? Case_Desc { get; set; }
        public int Case_PricePerDay { get; set; } = default!;
        public ICollection<Ads>? Ads { get; set; }
        public ICollection<Map_ADArea>? Map_ADAreas { get; set; } 

    }
}
