using FastBite.Core.Contracts;
using FastBite.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FastBite.Core.Services
{
    public class DBCustomerService : ICustomerService
    {
        private readonly string _connectionString;

        public DBCustomerService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // ─────────────────────────────────────────
        // MAP ROW — DRY helper
        // ─────────────────────────────────────────
        private Customer MapRow(SqlDataReader reader)
        {
            var customer = new Customer();
            customer.Id      = reader["Id"].ToString();
            customer.Name    = reader["Name"].ToString();
            customer.Phone   = reader["Phone"].ToString();

            // Email and Address can be NULL in DB — check before reading
            int emailOrdinal   = reader.GetOrdinal("Email");
            int addressOrdinal = reader.GetOrdinal("Address");

            customer.Email   = reader.IsDBNull(emailOrdinal)   ? "" : reader["Email"].ToString();
            customer.Address = reader.IsDBNull(addressOrdinal) ? "" : reader["Address"].ToString();

            return customer;
        }

        // ─────────────────────────────────────────
        // ADD
        // ─────────────────────────────────────────
        void ICustomerService.Add(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Customer cannot be null");

            string sql = "INSERT INTO Customers (Id, Name, Phone, Email, Address) " +
                         "VALUES (@Id, @Name, @Phone, @Email, @Address)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id",      customer.Id);
                cmd.Parameters.AddWithValue("@Name",    customer.Name);
                cmd.Parameters.AddWithValue("@Phone",   customer.Phone);
                cmd.Parameters.AddWithValue("@Email",   (object)customer.Email   ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)customer.Address ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        // ─────────────────────────────────────────
        // UPDATE
        // ─────────────────────────────────────────
        void ICustomerService.Update(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Customer cannot be null");

            string sql = "UPDATE Customers " +
                         "SET Name = @Name, Phone = @Phone, " +
                         "    Email = @Email, Address = @Address " +
                         "WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id",      customer.Id);
                cmd.Parameters.AddWithValue("@Name",    customer.Name);
                cmd.Parameters.AddWithValue("@Phone",   customer.Phone);
                cmd.Parameters.AddWithValue("@Email",   (object)customer.Email   ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Address", (object)customer.Address ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        // ─────────────────────────────────────────
        // DELETE
        // ─────────────────────────────────────────
        void ICustomerService.Delete(string id)
        {
            string sql = "DELETE FROM Customers WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ─────────────────────────────────────────
        // GET BY ID
        // ─────────────────────────────────────────
        Customer ICustomerService.GetById(string id)
        {
            string sql = "SELECT * FROM Customers WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return MapRow(reader);
                }
            }

            return null;
        }

        // ─────────────────────────────────────────
        // GET ALL
        // ─────────────────────────────────────────
        List<Customer> ICustomerService.GetAll()
        {
            List<Customer> customers = new List<Customer>();
            string sql = "SELECT * FROM Customers ORDER BY Name";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        customers.Add(MapRow(reader));
                }
            }

            return customers;
        }

        // ─────────────────────────────────────────
        // SEARCH — by name or phone
        // ─────────────────────────────────────────
        List<Customer> ICustomerService.Search(string query)
        {
            List<Customer> customers = new List<Customer>();

            string sql = "SELECT * FROM Customers " +
                         "WHERE Name LIKE @Query OR Phone LIKE @Query " +
                         "ORDER BY Name";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Query", "%" + query + "%");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        customers.Add(MapRow(reader));
                }
            }

            return customers;
        }
    }
}
