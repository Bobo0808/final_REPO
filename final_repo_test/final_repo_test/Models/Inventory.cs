using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Inventory
    {
        [Key]
        public int I_ID { get; set; }
        public int? C_ID { get; set; }
        public int? Item_ID { get; set; }
        public int? Quantity { get; set; }
    }
}
