using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassLibrary.Models
{
    [ModelMetadataType(typeof(CardOrdersMetadata))]
    public partial class CardOrder
    {
    }

    [ModelMetadataType(typeof(CardMetadata))]
    public partial class Card
    {
    }
}
