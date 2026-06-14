using FastBite.Core.Models;
using FastBite.Core.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FastBite.Core.Contracts
{
    public interface IMenuItemService
    {
        FoodItem Add(FoodItem item);
        bool Update(FoodItem item);
        bool Delete(string id);
        FoodItem GetById(string id);
        List<FoodItem> GetAll();
        Task<List<FoodItem>> GetAllAsync();
        List<FoodItem> Search(string text, MenuCategoryEnum? category, MenuItemStatusEnum? status);
    }
}