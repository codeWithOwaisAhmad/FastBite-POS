using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class Order
    {
        internal PaymentMethodEnum PaymentMethod;

        public string Id { get; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }
        public OrderStatusEnum Status { get; set; }
        
        public PaymentMethodEnum PaymentMenthod { get; set; }

        public Order()
        {
            Id = "O-" + Guid.NewGuid().ToString("N").Substring(0, 9);
            Items = new List<OrderItem>();
            OrderDate = DateTime.Now;
            Status =OrderStatusEnum.Pending;
        }
        public decimal TotalAmount()
        {
            return Items.Sum(item => item.Total());
        }

    }
}
