using System;
using System.Collections.Generic;

namespace DataService.Interface
{
    public interface IOrderDataService
    {
        //Single Order
        Order GetSingleOrder(int id);

        //All Orders
        List<Order> GetAllOrders();


        //All Orders of a signle Client
        List<Order> GetAllOrderByClient(int clientId);

        //All Orders of a Client per target date (30, 60, or 90)
        List<Order> GetAllOrderByClientAndRange(int clientId, DateTime range);

        //Create
        bool CreateOrder(Order newOrder);

        //Update
        bool UpdateOrder(Order updatedOrder);

        //Delete
        bool DeleteOrder(int id);
    }
}
