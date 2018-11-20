using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RestSharp.Deserializers;
using Veeqo.Api;
using Veeqo.Resources.Domain;
using VeeqoRepository;
using VeeqoRepository.Models;

namespace Veeqo.Service
{
    public class OrdersService
    {
        private readonly OrdersApi _ordersApi;
        private readonly OrdersRepository _repo;

        public OrdersService()
        {
            _ordersApi = new OrdersApi();
            _repo = new OrdersRepository();
        }

        public void UpdateVeeqoOrders()
        {
            var orders = _ordersApi.GetOrders();
            var ordersResources = JsonConvert.DeserializeObject<OrdersResource[]>(orders);
            MapOrderResourceToOrders(ordersResources[0]);
        }

        public void MapOrderResourceToOrders(OrdersResource orderResource)
        {
            try
            {
                var orders = new Orders();
                orders.OrderNumber = orderResource.allocations[0].line_items[0].sellable.product.title;
                _repo.Add(orders);
                _repo.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }
    }
}
