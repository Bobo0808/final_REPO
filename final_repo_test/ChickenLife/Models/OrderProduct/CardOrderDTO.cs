using System.ComponentModel.DataAnnotations.Schema;
using ClassLibrary.Models;

namespace ChickenLife.Models.OrderProduct
{
    public class CardOrderDTO
    {
        public int CO_ID { get; set; } = default!;
        public int A_ID { get; set; } = default!;
        //public UserAccount Account { get; set; } = default!;
        public int CA_ID { get; set; } = default!;
        //public Card Card { get; set; } = default!;
        public string CA_Name { get; set; } = default!;
        public int CT_ID { get; set; } = default!;
        //public CardType CardType { get; set; } = default!;
        public int CO_Sum { get; set; } = default!;
        public DateTime CO_Date { get; set; } = default!;
        public bool CO_Cancel { get; set; } = default!;
        public int CO_Quantity { get; set; } = default!;
    }
}