using final_repo_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace final_repo_test.Models
{
    [ModelMetadataType(typeof(OrdersMetadata))]
    public partial class Order
    {
    }
    [ModelMetadataType(typeof(ProductsMetadata))]
    public partial class Product
    {
    }
}
