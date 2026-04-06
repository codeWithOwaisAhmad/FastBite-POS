using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App.Core.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        private List<Customer> _customers = new List<Customer>();

        public List<Customer> GetAll()
        {
            return _customers.ToList();
        }

        public Customer GetById(string id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Customer is null");

            _customers.Add(customer); // ID already generated in model ✅
        }

        public void Update(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Customer is null");

            var existing = _customers.FirstOrDefault(c => c.Id == customer.Id);

            if (existing == null)
                throw new Exception($"Customer with {customer.Id} not found");

            existing.Name = customer.Name;
            existing.Phone = customer.Phone;
            existing.Email = customer.Email;
            existing.Address = customer.Address;
        }

        public void Delete(string id)
        {
            _customers.RemoveAll(c => c.Id == id);
        }

        public List<Customer> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return GetAll();

            return _customers
                .Where(c => c.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}