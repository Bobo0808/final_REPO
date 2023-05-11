using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassLibrary.Models
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
