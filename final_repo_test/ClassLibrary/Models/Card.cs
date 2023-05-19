using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Models
{
    public partial class Card
    {
        [Key]
        public int CA_ID { get; set; }
        public string CA_Name { get; set; } = default!;
        public int CA_Price { get; set; } = default!;
        public string CA_Image { get; set; } = default!;
        public string CA_Describe { get; set; } = default!;
        public DateTime CA_Date { get; set; } = default!;
        public bool CA_Discontinuted { get; set; } = default!;
        public ICollection<CardOrder>? CardOrders { get; set; }
    }
}
