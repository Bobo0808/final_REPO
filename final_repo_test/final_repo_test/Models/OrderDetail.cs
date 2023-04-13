using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class OrderDetail
    {
        [Key]
        public int Od_ID { get; set; }
        public int Od_O_ID { get; set; }
        public int Od_P_ID { get; set; }
        public int? Od_UnitPrice { get; set; }
        public int? Od_Sum { get; set; }
        public int? Od_Quantity { get; set; }
    }
}
