using FastBite.Core.Models;
using FastBite.Core.Utilities;
using System.Collections.Generic;

namespace FastBite.Core.Contracts
{
    public interface IOrderService
    {
        // Basic CRUD
        void Add(Order order);
        void Update(Order order);
        void Delete(string id);
        Order GetById(string id);

        // Get all orders
        List<Order> GetAll();

        // Filtered queries
        List<Order> GetByStatus(OrderStatusEnum status);
        List<Order> GetByCustomerId(string customerId);

        // Dashboard summary data
        decimal GetTotalRevenue();
        int GetTotalOrdersCount();
        Dictionary<string, decimal> GetRevenueByCategory();
        Dictionary<string, int> GetOrderCountByStatus();
        Dictionary<string, decimal> GetDailyRevenueLastWeek();
    }
}
