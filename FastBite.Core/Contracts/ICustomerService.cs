using FastBite.Core.Models;
using System.Collections.Generic;

namespace FastBite.Core.Contracts
{
    public interface ICustomerService
    {
        // Basic CRUD
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(string id);
        Customer GetById(string id);

        // Get all customers
        List<Customer> GetAll();

        // Search by name or phone
        List<Customer> Search(string query);
    }
}
