using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class OrderDetail
    {
        [Key]
        public int Od_ID { get; set; }
        [ForeignKey("Order")]
        public int O_ID { get; set; }
        public Order? Order { get; set; }
        [ForeignKey("Product")]
        public int P_ID { get; set; }
        public Product? Product { get; set; }
        public int? Od_UnitPrice { get; set; }
        public int? Od_Sum { get; set; }
        public int? Od_Quantity { get; set; }

    }
}
