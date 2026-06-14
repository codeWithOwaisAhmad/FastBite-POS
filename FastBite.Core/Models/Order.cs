using FastBite.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FastBite.Core.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatusEnum Status { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public decimal TotalAmount { get; set; }   // stored directly
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Id = "O-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
            Items = new List<OrderItem>();
            OrderDate = DateTime.Now;
            Status = OrderStatusEnum.Pending;
            PaymentMethod = PaymentMethodEnum.Cash;
            TotalAmount = 0;
        }

        // Call this before saving to DB to sync TotalAmount with items
        public void RecalculateTotal()
        {
            if (Items != null && Items.Count > 0)
                TotalAmount = Items.Sum(i => i.Total());
            else
                TotalAmount = 0;
        }
    }
}