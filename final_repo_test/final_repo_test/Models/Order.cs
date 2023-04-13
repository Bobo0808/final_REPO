using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Order
    {
        [Key]
        public int O_ID { get; set; }
        public int O_A_ID { get; set; }
        public DateTime? O_Date { get; set; }
        public int? O_TotalPrice { get; set; }
        public bool? O_Cancle { get; set; }








    }
}
