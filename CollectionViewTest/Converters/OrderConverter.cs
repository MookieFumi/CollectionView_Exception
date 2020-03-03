using System.Linq;
using CollectionViewTest.Model;
using Xamarin.Forms;

namespace CollectionViewTest.Converters
{
    public class OrderConverter : ConverterBase<OrderDTO, Order>
    {
        private readonly string _currencySymbol;

        public OrderConverter(string currencySymbol)
        {
            _currencySymbol = currencySymbol;
        }

        protected override Order ConvertImpl(OrderDTO source)
        {
            return new Order
            {
                Id = source.Id,
                Code = source.Code,
                StatusColor = Color.Salmon,
                //StatusColor = ConvertStatusToColor(source.StatusCode),
                //Image = ConvertOrderTypeToImage(source.Type),
                Type = source.Type,
                OrderType = "Pickup",
                //OrderType = TranslateOrderType(source.Type),

                DayNumberAndMonthName = (source.RealInitialTime ?? source.PlannedInitialTime ?? source.RequestInitialTime).ToString("dd MMMM"),
                DayName = (source.RealInitialTime ?? source.PlannedInitialTime ?? source.RequestInitialTime).ToString("dddd"),

                DisplayedInitialTime = source.RealInitialTime ?? source.PlannedInitialTime ?? source.RequestInitialTime,
                DisplayedFinalTime = source.RealFinalTime ?? source.PlannedFinalTime ?? source.RequestFinalTime,

                StatusDescription = source.StatusDescription,
                ShowTotalAmounts = source.Type != OrderType.Supply && source.Type != OrderType.TechnicalAssistance,
                TotalAmounts = source.RequestedAmounts?.Sum(a => a.TotalAmount) ?? 0,
                CurrencySymbol = _currencySymbol,

                RequestedInitialTime = source.RequestInitialTime,
                RequestedFinalTime = source.RequestFinalTime,

                PlannedInitialTime = source.PlannedInitialTime,
                PlannedFinalTime = source.PlannedFinalTime,

                RealInitialTime = source.RealInitialTime,
                RealFinalTime = source.RealFinalTime,

                //TODO Avoid magic string
                RatingIsEnabled = source.StatusCode.ToUpper().Equals("DONE"),
                //RatingReplaceStringMap = GetRatingReplaceStringMap(source.StatusCode),
                //RatingImage = GetRatingImage(source.Rate),
                RateId = source.RateId,
                Rate = source.Rate,

                //TODO Avoid magic string
                DetailIsEnabled = !source.StatusCode.ToUpper().Equals("PENDING"),
                //DetailReplaceStringMap = GetDetailReplaceStringMap(source.StatusCode),
                //DetailImage = $"{Configuration.ImagesNameSpace}search.svg"
            };
        }
    }
}
