using System;

namespace FastBite.Core.Models
{
    public class OrderItem
    {
        public int    Id           { get; set; }   // DB IDENTITY column
        public string OrderId      { get; set; }
        public string MenuItemId   { get; set; }
        public string MenuItemName { get; set; }
        public decimal UnitPrice   { get; set; }
        public int    Quantity     { get; set; }

        public decimal Total()
        {
            return UnitPrice * Quantity;
        }
    }
}
