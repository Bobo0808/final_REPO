using ClassLibrary.Enum;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ClassLibrary.Models
{
    public class CardMetadata
    {
        [Display(Name = "商品編號")]
        public int CA_ID { get; set; } = default!;
        [Display(Name = "商品名字")]
        public string CA_Name { get; set; } = default!;
        [Display(Name = "商品價格")]
        public int CA_Price { get; set; } = default!;
        [Display(Name = "商品圖片")]
        public string CA_Image { get; set; } = default!;
        [Display(Name = "商品介紹")]
        public string CA_Describe { get; set; } = default!;
        [Display(Name = "建立日期")]
        public DateTime CA_Date { get; set; } = default!;
        [Display(Name = "是否下架")]
        public bool CA_Discontinuted { get; set; } = default!;
    }
}
