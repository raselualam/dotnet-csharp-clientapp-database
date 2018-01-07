using DataService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataService.Services
{
    public class OrderDataService : IOrderDataService
    {
        //Field 
        private DatabaseToClassesDataContext _db;

        //Constructor
        public OrderDataService()
        {
            _db = new DatabaseToClassesDataContext();
        }

        //Methods
        public bool CreateOrder(Order newOrder)
        {
            try
            {
                _db.Orders.InsertOnSubmit(newOrder);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteOrder(int id)
        {
            try
            {
                var orderToBeDeleted = GetSingleOrder(id);
                _db.Orders.DeleteOnSubmit(orderToBeDeleted);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Order> GetAllOrderByClient(int clientId)
        {
            var ordersByClient = _db.Orders
                               .Where(row => row.Client_Id == clientId);
            return ordersByClient.ToList();
        }

        public List<Order> GetAllOrderByClientAndRange(int clientId, DateTime range)
        {
            var orders = _db.Orders
                         .Where(row => row.Client_Id == clientId)
                         .Where(row => row.Created <= range);
            return orders.ToList();
        }

        public List<Order> GetAllOrders()
        {
            var allOrders = _db.Orders;
            return allOrders.ToList();
        }

        public Order GetSingleOrder(int id)
        {
            var order = _db.Orders
                        .Where(row => row.Id == id)
                        .Single();
            return order;
        }

        public bool UpdateOrder(Order updatedOrder)
        {
            try
            {
                var oldOrder = GetSingleOrder(updatedOrder.Id);
                oldOrder.Client_Id = updatedOrder.Client_Id;
                oldOrder.Created = updatedOrder.Created;
                oldOrder.Description = updatedOrder.Description;
                oldOrder.Shipped = updatedOrder.Shipped;
                oldOrder.Total = updatedOrder.Total;

                _db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
