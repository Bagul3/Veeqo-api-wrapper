using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace Veeqo.Api
{
    public class OrdersApi
    {
        public string GetOrders()
        {
            var client = new RestSharpBase("orders?page_size=2&page=1&status=awaiting_fulfillment&created_at_min=2018-03-01", Method.GET);
            return client.Execute().Content;
        }
    }
}
