using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Models
{
    public class CardType
    {
        [Key]
        public int CT_ID { get; set; } = default!;
        public string CT_Name { get; set; } = default!;
        public ICollection<CardOrder>? CardOrders { get; set; }
    }
}
