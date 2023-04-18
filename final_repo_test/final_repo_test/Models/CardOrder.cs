using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class CardOrder
    {
        [Key]
        public int CO_ID { get; set; } = default!;
        [ForeignKey("Account")]
        public int A_ID { get; set; } = default!;
        public UserAccount Account { get; set; } = default!;
        [ForeignKey("Card")]
        public int CA_Price { get; set; } = default!;
        public Card Card { get; set; } = default!;
        public int CO_Sum { get; set; } = default!;
        public int CO_Quantity { get; set; } = default!;
    }
}
