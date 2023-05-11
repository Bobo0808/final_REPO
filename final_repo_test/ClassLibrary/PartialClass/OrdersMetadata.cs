using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Models
{
    public class OrdersMetadata
    {
        [Display(Name = "訂單編號")]
        public int O_ID { get; set; } = default!;
        [Display(Name = "會員編號")]
        public int A_ID { get; set; } = default!;
        [Display(Name = "訂單日期")]
        public DateTime O_Date { get; set; } = default!;
        [Display(Name = "訂單金額")]
        public int O_TotalPrice { get; set; } = default!;
        [Display(Name = "訂單取消")]
        public bool O_Cancle { get; set; } = default!;
    }
}
