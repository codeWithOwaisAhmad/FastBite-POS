using FastBite.Core.Utilities;
using System;

namespace FastBite.Core.Models
{
    public class FoodItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public MenuCategoryEnum Category { get; set; }
        public decimal Price { get; set; }
        public MenuItemStatusEnum Status { get; set; }

        public FoodItem()
        {
            Id = "M-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        }
    }
}
