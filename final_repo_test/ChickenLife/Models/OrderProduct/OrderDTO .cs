using System.ComponentModel.DataAnnotations.Schema;
using ClassLibrary.Models;

namespace ChickenLife.Models.OrderProduct.DTO
{
    public class OrderDTO
    {
        public int O_ID { get; set; } = default!;

        public int A_ID { get; set; } = default!;
        //public UserAccount Account { get; set; } = default!;
        public DateTime O_Date { get; set; } = default!;
        public int O_TotalPrice { get; set; } = default!;
        public bool O_Cancle { get; set; } = default!;

        public string ProductName { get; set; } = default!;

        //public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}