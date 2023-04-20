using final_repo_test.Models;
using System.ComponentModel.DataAnnotations;

namespace final_repo_test.Areas.OrderProduct.ViewModels
{
    public class ViewOrder
    {
        public int O_ID { get; set; }
        public int A_ID { get; set; }
        public DateTime? O_Date { get; set; }
        public int? O_TotalPrice { get; set; }
        public bool O_Cancle { get; set; }

        public string? UserName { get; set; }

        public Order Order { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public List<Product> Products { get; set; }
    }
}
