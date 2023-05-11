using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;

namespace ClassLibrary.ViewModels.OrderProduct
{
    public class OrderDetailViewModel
    {
        public Order selectOrder { get; set; }

        public OrderDetail selectDetails { get; set; }

        public string ProductName { get; set; }
    }
}
