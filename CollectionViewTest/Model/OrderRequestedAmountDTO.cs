using Newtonsoft.Json;

namespace CollectionViewTest.Model
{
    public class OrderRequestedAmountDTO
    {
        [JsonProperty("currencyDescription")]
        public string CurrencyDescription { get; set; }

        [JsonProperty("currencyIsoCode")]
        public string CurrencyIsoCode { get; set; }

        [JsonProperty("totalAmount")]
        public decimal TotalAmount { get; set; }
    }
}
