using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CollectionViewTest.Model
{
    public class Order
    {
        public string Id { get; set; }

        public string Code { get; set; }

        public bool HasCode => !string.IsNullOrEmpty(Code);

        public string StatusDescription { get; set; }
        public Color StatusColor { get; set; }

        public string Image { get; set; }

        public OrderType Type { get; set; }
        public string OrderType { get; set; }

        public string DayNumberAndMonthName { get; set; }
        public string DayName { get; set; }

        public DateTime DisplayedInitialTime { get; set; }
        public DateTime DisplayedFinalTime { get; set; }

        public bool ShowTotalAmounts { get; set; }
        public decimal TotalAmounts { get; set; }
        public string CurrencySymbol { get; set; }

        public bool RatingIsEnabled { get; set; }
        public Dictionary<string, string> RatingReplaceStringMap { get; set; }
        public string RatingImage { get; set; }
        public int Rate { get; set; }
        public string RateId { get; set; }

        public bool DetailIsEnabled { get; set; }
        public Dictionary<string, string> DetailReplaceStringMap { get; set; }
        public string DetailImage { get; set; }

        public DateTime RequestedInitialTime { get; set; }
        public DateTime RequestedFinalTime { get; set; }

        public DateTime? PlannedInitialTime { get; set; }
        public DateTime? PlannedFinalTime { get; set; }

        public DateTime? RealInitialTime { get; set; }
        public DateTime? RealFinalTime { get; set; }
    }
}
