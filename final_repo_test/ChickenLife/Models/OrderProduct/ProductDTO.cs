using ClassLibrary.Models;
using ClassLibrary.Enum;

namespace ChickenLife.Models.OrderProduct.DTO
{
    public class ProductDTO
    {
        public int P_ID { get; set; } = default!;

        public string P_Name { get; set; } = default!;
        public int P_ProductType { get; set; } = default!;
        public int P_Price { get; set; } = default!;
        public string P_Image { get; set; } = default!;
        public string P_Describe { get; set; } = default!;
        public int P_Instock { get; set; } = default!;
        public DateTime P_Date { get; set; } = default!;
        public int P_Discount { get; set; } = default!;
        public bool P_Discontinuted { get; set; } = default!;

    }
}