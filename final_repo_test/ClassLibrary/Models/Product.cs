using ClassLibrary.Enum;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Models
{
    public partial class Product
    {
        [Key]
        public int P_ID { get; set; } = default!;

        public string P_Name { get; set; } = default!;
        public ProductType P_ProductType { get; set; } = default!;
        public int P_Price { get; set; } = default!;
        public string P_Image { get; set; } = default!;
        public string P_Describe { get; set; } = default!;
        public int P_Instock { get; set; } = default!;
        public DateTime P_Date { get; set; } = default!;
        public int P_Discount { get; set; } = default!;
        public bool P_Discontinuted { get; set; } = default!;

        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public ICollection<UserAccount>? Accounts { get; set; }
    }
}
