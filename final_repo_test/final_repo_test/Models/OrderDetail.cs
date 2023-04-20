using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class OrderDetail
    {
        [Key]
        public int Od_ID { get; set; } = default!;
        [ForeignKey("Order")]
        public int O_ID { get; set; } = default!;
        public Order Order { get; set; } = default!;
        [ForeignKey("Product")]
        public int P_ID { get; set; } = default!;
        public Product Product { get; set; } = default!;
        public int Od_UnitPrice { get; set; } = default!;
        public int Od_Sum { get; set; } = default!;
        public int Od_Quantity { get; set; } = default!;

    }
}
