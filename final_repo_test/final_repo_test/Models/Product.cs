using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Models
{
    public class Product
    {
        [Key]
        public int P_ID { get; set; }

        public string? P_Name { get; set; }
        public string? P_Type { get; set; }
        public int? P_Price { get; set; }
        public string? P_Image { get; set; }
        public string? P_Describe { get; set; }
        public int? P_Instock { get; set; }
        public DateTime? P_Date { get; set; }
        public string? P_Discount { get; set; }
        public bool? P_Discontinuted { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
