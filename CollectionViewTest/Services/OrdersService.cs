using System.Collections.Generic;
using System.Threading.Tasks;
using CollectionViewTest.Model;

namespace CollectionViewTest.Services
{
    public class OrdersService : IOrdersService
    {
        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {
            //await Task.Delay(99);

            var response = GetResponse();

            return await Task.FromResult(Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<OrderDTO>>(response));
        }

        private string GetResponse()
        {
            return @"[
    {
        ""plannedFinalTime"": ""2020-03-02T16:50:00+01:00"",
        ""plannedInitialTime"": ""2020-03-02T12:00:00+01:00"",
        ""requestFinalTime"": ""2020-03-02T16:50:00+01:00"",
        ""requestInitialTime"": ""2020-03-02T12:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""264470E"",
        ""serviceId"": ""92866577-5a56-11ea-85e7-cbf81989b4a1"",
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""RECEIVED"",
        ""serviceStatusDescription"": ""Received"",
        ""serviceType"": 0,
        ""requestedAmounts"": []
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-26T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T11:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""263476E"",
        ""serviceId"": ""9e19e0f6-571f-11ea-bd0e-dd7f14c69f10"",
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""RECEIVED"",
        ""serviceStatusDescription"": ""Received"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 8500.0
            }
        ]
    },
    {
        ""plannedFinalTime"": ""2020-02-24T19:00:00+01:00"",
        ""plannedInitialTime"": ""2020-02-24T12:00:00+01:00"",
        ""requestFinalTime"": ""2020-02-24T19:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-24T12:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""262973E"",
        ""serviceId"": ""6a9a1369-5484-11ea-bd0e-05e33baa9a79"",
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""RECEIVED"",
        ""serviceStatusDescription"": ""Received"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 3210.0
            }
        ]
    },
    {
        ""plannedFinalTime"": ""2020-02-25T11:30:00+01:00"",
        ""plannedInitialTime"": ""2020-02-25T11:25:00+01:00"",
        ""requestFinalTime"": ""2020-02-26T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T11:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""263474E"",
        ""serviceId"": ""820217e8-571b-11ea-bd0e-6f02886daae1"",
        ""serviceRate"": 4,
        ""serviceRateId"": ""a13ee6d8-57c1-11ea-bfd8-cd720ed78b4f"",
        ""serviceStatusCode"": ""DONE"",
        ""serviceStatusDescription"": ""Done"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 4000.0
            },
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 50.0
            }
        ]
    },
    {
        ""plannedFinalTime"": ""2020-02-25T11:35:00+01:00"",
        ""plannedInitialTime"": ""2020-02-25T11:30:00+01:00"",
        ""requestFinalTime"": ""2020-02-26T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T11:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""263968E"",
        ""serviceId"": ""69748a51-571b-11ea-bd0e-a1b7e1e4348e"",
        ""serviceRate"": 4,
        ""serviceRateId"": ""bb35a99b-57b3-11ea-bfd8-5b839e9b3ff2"",
        ""serviceStatusCode"": ""DONE"",
        ""serviceStatusDescription"": ""Done"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 7350.0
            }
        ]
    },
    {
        ""plannedFinalTime"": ""2020-02-25T11:40:00+01:00"",
        ""plannedInitialTime"": ""2020-02-25T11:35:00+01:00"",
        ""requestFinalTime"": ""2020-02-26T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T11:00:00+01:00"",
        ""realInitialTime"": ""2020-02-24T20:55:59+01:00"",
        ""realFinalTime"": null,
        ""serviceCode"": ""263475E"",
        ""serviceId"": ""4f5b2c9a-571b-11ea-bd0e-5f75a2dfc995"",
        ""serviceRate"": 5,
        ""serviceRateId"": ""6954393a-5959-11ea-aded-ddb294d84a70"",
        ""serviceStatusCode"": ""DONE"",
        ""serviceStatusDescription"": ""Done"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 5670.0
            }
        ]
    },
    {
        ""plannedFinalTime"": ""2020-02-25T19:00:00+01:00"",
        ""plannedInitialTime"": ""2020-02-25T12:00:00+01:00"",
        ""requestFinalTime"": ""2020-02-25T19:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T12:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""262472E"",
        ""serviceId"": ""637b32db-530d-11ea-bd0e-5f3733f1da9f"",
        ""serviceRate"": 4,
        ""serviceRateId"": ""cbd4f7fb-5312-11ea-bfd8-ebd3b689802b"",
        ""serviceStatusCode"": ""DONE"",
        ""serviceStatusDescription"": ""Done"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 88500.0
            },
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 10678.0
            }
        ]
    },
    {
        ""plannedFinalTime"": ""2020-02-26T19:00:00+01:00"",
        ""plannedInitialTime"": ""2020-02-26T12:00:00+01:00"",
        ""requestFinalTime"": ""2020-02-26T19:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-26T12:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""263469E"",
        ""serviceId"": ""bb99223b-56f6-11ea-bd0e-e95fba635311"",
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""RECEIVED"",
        ""serviceStatusDescription"": ""Received"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 17500.0
            }
        ]
    },
    {
        ""plannedFinalTime"": ""2020-02-28T19:00:00+01:00"",
        ""plannedInitialTime"": ""2020-02-28T12:00:00+01:00"",
        ""requestFinalTime"": ""2020-02-28T19:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-28T12:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""262972E"",
        ""serviceId"": ""16787293-5484-11ea-bd0e-512c566f7264"",
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""RECEIVED"",
        ""serviceStatusDescription"": ""Received"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 4340.0
            }
        ]
    },
    {
        ""plannedFinalTime"": ""2020-02-25T03:59:00+01:00"",
        ""plannedInitialTime"": ""2020-02-24T04:00:00+01:00"",
        ""requestFinalTime"": ""2020-02-25T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-24T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": ""263471E"",
        ""serviceId"": ""f8826548-56f6-11ea-bd0e-e3bc161da254"",
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""RECEIVED"",
        ""serviceStatusDescription"": ""Received"",
        ""serviceType"": 3,
        ""requestedAmounts"": []
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-26T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 4.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-29T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-28T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 888.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-27T00:50:00+01:00"",
        ""requestInitialTime"": ""2020-02-26T21:50:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 1290000.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-29T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-28T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 0.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-26T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 8888.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-27T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-26T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 6000.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-29T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-28T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 0.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-27T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-26T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 40.25
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-26T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-26T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 4,
        ""requestedAmounts"": []
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-25T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 50000.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-25T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 63900.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-27T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-26T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 34057.50
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-03-01T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-29T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 88977.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-03-01T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-29T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": []
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-27T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-26T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 1,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 49.6
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-24T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-24T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 25000.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-02-25T04:00:00+01:00"",
        ""requestInitialTime"": ""2020-02-25T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 63520.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-03-01T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-29T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 987654.0
            }
        ]
    },
    {
        ""plannedFinalTime"": null,
        ""plannedInitialTime"": null,
        ""requestFinalTime"": ""2020-03-01T03:59:00+01:00"",
        ""requestInitialTime"": ""2020-02-29T04:00:00+01:00"",
        ""realInitialTime"": null,
        ""realFinalTime"": null,
        ""serviceCode"": null,
        ""serviceId"": null,
        ""serviceRate"": 0,
        ""serviceRateId"": null,
        ""serviceStatusCode"": ""PENDING"",
        ""serviceStatusDescription"": ""Pending"",
        ""serviceType"": 0,
        ""requestedAmounts"": [
            {
                ""currencyDescription"": ""Euros"",
                ""currencyIsoCode"": ""EUR"",
                ""totalAmount"": 0.0
            }
        ]
    }
]";
        }
    }
}
