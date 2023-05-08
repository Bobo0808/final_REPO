using final_repo_test.Models;
using Microsoft.AspNetCore.Http;

namespace final_repo_test.Areas.OrderProduct.ViewModels
{
    public class CardDetailViewModel
    {
        public CardOrder selectCard { get; set; }

        public CardType selectCardType { get; set; }

        public string CardProductName { get; set; }
        public string MemberName { get; set; }
    }
}
