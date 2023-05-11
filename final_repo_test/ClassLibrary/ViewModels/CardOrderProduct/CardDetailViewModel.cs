using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;

namespace ClassLibrary.ViewModels.CardOrderProduct
{
    public class CardDetailViewModel
    {
        public CardOrder selectCard { get; set; }

        public CardType selectCardType { get; set; }

        public string CardProductName { get; set; }
        public string MemberName { get; set; }
    }
}
