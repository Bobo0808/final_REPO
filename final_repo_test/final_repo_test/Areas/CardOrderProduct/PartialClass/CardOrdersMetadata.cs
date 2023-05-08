using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_repo_test.Models
{
    public class CardOrdersMetadata
    {
        [Display(Name = "訂單編號")]
        public int CO_ID { get; set; } = default!;
        [Display(Name = "會員名字")]
        public int A_ID { get; set; } = default!;
        [Display(Name = "產品名字")]
        public int CA_ID { get; set; } = default!;
        [Display(Name = "付款選擇")]
        public int CT_ID { get; set; } = default!;
        [Display(Name = "訂單數量")]
        public int CO_Quantity { get; set; } = default!;
        [Display(Name = "訂單價格")]
        public int CO_Sum { get; set; } = default!;
        
    }
}
