using System;
using System.Collections.Generic;
using CollectionViewTest.Converters;
using Newtonsoft.Json;

namespace CollectionViewTest.Model
{
    public class OrderDTO
    {
        public OrderDTO()
        {
            RequestedAmounts = new List<OrderRequestedAmountDTO>();
        }

        [JsonProperty("plannedFinalTime")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime? PlannedFinalTime { get; set; }

        [JsonProperty("plannedInitialTime")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime? PlannedInitialTime { get; set; }

        [JsonProperty("requestFinalTime")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime RequestFinalTime { get; set; }

        [JsonProperty("requestInitialTime")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime RequestInitialTime { get; set; }

        [JsonProperty("realInitialTime")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime? RealInitialTime { get; set; }

        [JsonProperty("realFinalTime")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime? RealFinalTime { get; set; }

        [JsonProperty("serviceCode")]
        public string Code { get; set; }

        [JsonProperty("serviceId")]
        public string Id { get; set; }

        [JsonProperty("serviceRate")]
        public int Rate { get; set; }

        [JsonProperty("serviceRateId")]
        public string RateId { get; set; }

        [JsonProperty("serviceStatusCode")]
        public string StatusCode { get; set; }

        [JsonProperty("serviceStatusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("serviceType")]
        public OrderType Type { get; set; }

        [JsonProperty("requestedAmounts")]
        public List<OrderRequestedAmountDTO> RequestedAmounts { get; set; }
    }
}
