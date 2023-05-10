using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public partial class CardOrder
    {
        [Key]
        public int CO_ID { get; set; } = default!;
        [ForeignKey("Account")]
        public int A_ID { get; set; } = default!;
        public UserAccount Account { get; set; } = default!;
        [ForeignKey("Card")]
        public int CA_ID { get; set; } = default!;
        public Card Card { get; set; } = default!;
        [ForeignKey("CardType")]
        public int CT_ID { get; set; } = default!;
        public CardType CardType { get; set; } = default!;
        public int CO_Sum { get; set; } = default!;
        public DateTime CO_Date { get; set; } = default!;
        public bool CO_Cancel { get; set; } = default!;
        public int CO_Quantity { get; set; } = default!;
    }
}
