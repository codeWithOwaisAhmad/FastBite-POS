using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Customer() { 

          Id ="C-" + Guid.NewGuid().ToString("N").Substring(0,9);
        }
    }
}
