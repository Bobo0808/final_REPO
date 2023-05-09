using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Models
{
    public class Partner
    {
        [Key]
        public int P_ID { get; set; } = default!;
        public string P_Name { get; set; } = default!;
        public string Contact { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string P_Note { get; set; } = default!;
        public ICollection<Ads>? Ads { get; set; }
    }
}
