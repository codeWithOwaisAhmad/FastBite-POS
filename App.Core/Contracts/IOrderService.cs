using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Contracts
{
    public interface IOrderService
    {
        public List<Order> GetAll();
        public Order GetById(string id);
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(string id);
         public List<Order> GetByCustomerId(string customerId);
        public List<Order> GetByStatus(OrderStatusEnum status);
         
    }
}
