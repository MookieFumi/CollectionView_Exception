using Newtonsoft.Json.Converters;

namespace CollectionViewTest.Converters
{

    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            base.DateTimeFormat = format;
        }
    }
}
