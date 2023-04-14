using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class Order
    {
        [Key]
        public int O_ID { get; set; }
        [ForeignKey("Account")]
        public int A_ID { get; set; }
        public Account? Account { get; set; }
        public DateTime? O_Date { get; set; }
        public int? O_TotalPrice { get; set; }
        public bool? O_Cancle { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }
        







    }
}
