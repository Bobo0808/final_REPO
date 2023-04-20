namespace final_repo_test.Models
{
    public class Ads_OrderStatus
    {
        public int OS_ID { get; set; } = default!;
        public string OS_Name { get; set; } = default!;
        public decimal OS_FullfillmentRate { get; set; } = default!;
        public decimal OS_PaymentMultiplier { get; set; } = default!;
        public ICollection<Ads>? Ads { get; set; }
    }
}
