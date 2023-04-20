using final_repo_test.Models;
using Microsoft.AspNetCore.Http;

namespace final_repo_test.Areas.OrderProduct.ViewModels
{
    public class OrderDetailViewModel
    {
        public Order selectOrder { get; set; }

        public OrderDetail selectDetails { get; set; }

        public string ProductName { get; set; }
    }
}
