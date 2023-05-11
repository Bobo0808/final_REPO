using ClassLibrary.Enum;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ClassLibrary.Models
{
    public class ProductsMetadata
    {
        [Display(Name = "商品編號")]
        public int P_ID { get; set; } = default!;
        [Display(Name = "商品名字")]
        public string P_Name { get; set; } = default!;
        [Display(Name = "商品型式")]
        public ProductType P_ProductType { get; set; } = default!;
        [Display(Name = "商品價格")]
        public int P_Price { get; set; } = default!;
        [Display(Name = "商品圖片")]
        public string P_Image { get; set; } = default!;
        [Display(Name = "商品介紹")]
        public string P_Describe { get; set; } = default!;
        [Display(Name = "商品庫存")]
        public int P_Instock { get; set; } = default!;
        [Display(Name = "建立日期")]
        public DateTime P_Date { get; set; } = default!;
        [Display(Name = "商品折扣")]
        public int P_Discount { get; set; } = default!;
        [Display(Name = "是否下架")]
        public bool P_Discontinuted { get; set; } = default!;
    }
}
