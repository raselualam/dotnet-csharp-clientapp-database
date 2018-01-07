using DataService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataService.Mock
{
    public class OrderMockDataService : IOrderDataService
    {
        //Field
        private List<Order> _mock;

        //Constructor
        public OrderMockDataService()
        {
            _mock = new List<Order>()
            {
                new Order {Id=1, Shipped= true, Description ="Erik"},
                new Order {Id=2, Shipped= false, Description="Erik1"},
                new Order {Id=3, Shipped= true, Description ="Erik2"},
                new Order {Id=4, Shipped= false, Description ="Erik3"},
                new Order {Id=5, Shipped= true, Description ="Erik4"},
            };
        }

        public bool CreateOrder(Order newOrder)
        {
            _mock.Add(newOrder);
            return true;
        }

        public bool DeleteOrder(int id)
        {
            var orderToBeDeleted = GetSingleOrder(id);
            _mock.Remove(orderToBeDeleted);
            return true;
        }

        public List<Order> GetAllOrderByClient(int clientId)
        {
            return _mock;
        }

        public List<Order> GetAllOrderByClientAndRange(int clientId, DateTime range)
        {
            return _mock;
        }

        public List<Order> GetAllOrders()
        {
            return _mock;
        }

        public Order GetSingleOrder(int id)
        {
            return _mock.Single(order => order.Id == id);
        }

        public bool UpdateOrder(Order updatedOrder)
        {
            var oldOrder = GetSingleOrder(updatedOrder.Id);

            _mock.Remove(oldOrder);
            _mock.Add(updatedOrder);

            return true;
        }
    }
}
