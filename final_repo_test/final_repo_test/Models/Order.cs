using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public partial class Order
    {
        [Key]
        public int O_ID { get; set; } = default!;
        [ForeignKey("Account")]
        public int A_ID { get; set; } = default!;
        public UserAccount Account { get; set; } = default!;
        public DateTime O_Date { get; set; } = default!;
        public int O_TotalPrice { get; set; } = default!;
        public bool O_Cancle { get; set; } = default!;

        public ICollection<OrderDetail>? OrderDetails { get; set; }
        







    }
}
