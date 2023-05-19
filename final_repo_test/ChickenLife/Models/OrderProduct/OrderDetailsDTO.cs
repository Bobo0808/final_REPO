using System.ComponentModel.DataAnnotations.Schema;
using ClassLibrary.Models;

namespace ChickenLife.Models.OrderProduct
{
    public class OrderDetailsDTO
    {
        public int Od_ID { get; set; } = default!;
        public int O_ID { get; set; } = default!;
        //public Order Order { get; set; } = default!;
        public int P_ID { get; set; } = default!;
        //public Product Product { get; set; } = default!;
        public int Od_UnitPrice { get; set; } = default!;
        public int Od_Sum { get; set; } = default!;
        public int Od_Quantity { get; set; } = default!;
    }
}