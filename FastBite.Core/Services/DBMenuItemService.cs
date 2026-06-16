using FastBite.Core.Contracts;
using FastBite.Core.Models;
using FastBite.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace FastBite.Core.Services
{
    public class DBMenuItemService : IMenuItemService
    {
        private readonly string _connectionString;

        public DBMenuItemService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // ─────────────────────────────────────────
        // MAP ROW
        // ─────────────────────────────────────────
        private FoodItem MapRow(SqlDataReader reader)
        {
            return new FoodItem
            {
                Id = reader["Id"].ToString(),
                Name = reader["Name"].ToString(),
                Category = Enum.Parse<MenuCategoryEnum>(reader["Category"].ToString()),
                Price = Convert.ToDecimal(reader["Price"]),
                Status = Enum.Parse<MenuItemStatusEnum>(reader["Status"].ToString())
            };
        }

        // ─────────────────────────────────────────
        // ADD
        // ─────────────────────────────────────────
        FoodItem IMenuItemService.Add(FoodItem item)
        {
            if (item == null)
                throw new ArgumentNullException("FoodItem cannot be null");

            item.Id = "M-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

            string sql = "INSERT INTO MenuItems (Id, Name, Category, Price, Status) " +
                         "VALUES (@Id, @Name, @Category, @Price, @Status)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Category", item.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@Status", item.Status.ToString());
                cmd.ExecuteNonQuery();
            }
            return item;
        }

        // ─────────────────────────────────────────
        // UPDATE
        // ─────────────────────────────────────────
        bool IMenuItemService.Update(FoodItem item)
        {
            if (item == null)
                throw new ArgumentNullException("FoodItem cannot be null");

            string sql = "UPDATE MenuItems " +
                         "SET Name = @Name, Category = @Category, " +
                         "    Price = @Price, Status = @Status " +
                         "WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Category", item.Category.ToString());
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@Status", item.Status.ToString());
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ─────────────────────────────────────────
        // DELETE
        // ─────────────────────────────────────────
        bool IMenuItemService.Delete(string id)
        {
            string sql = "DELETE FROM MenuItems WHERE Id = @Id";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ─────────────────────────────────────────
        // GET BY ID
        // ─────────────────────────────────────────
        FoodItem IMenuItemService.GetById(string id)
        {
            string sql = "SELECT * FROM MenuItems WHERE Id = @Id";
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
        List<FoodItem> IMenuItemService.GetAll()
        {
            List<FoodItem> items = new List<FoodItem>();
            string sql = "SELECT * FROM MenuItems ORDER BY Category, Name";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        items.Add(MapRow(reader));
                }
            }
            return items;
        }

        // ─────────────────────────────────────────
        // GET ALL ASYNC
        // ─────────────────────────────────────────
        async Task<List<FoodItem>> IMenuItemService.GetAllAsync()
        {
            List<FoodItem> items = new List<FoodItem>();
            string sql = "SELECT * FROM MenuItems ORDER BY Category, Name";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                        items.Add(MapRow(reader));
                }
            }
            return items;
        }

        // ─────────────────────────────────────────
        // SEARCH
        // ─────────────────────────────────────────
        List<FoodItem> IMenuItemService.Search(string text,
            MenuCategoryEnum? category, MenuItemStatusEnum? status)
        {
            List<FoodItem> items = new List<FoodItem>();
            string sql = "SELECT * FROM MenuItems WHERE Name LIKE @Text";

            if (category != null)
                sql += " AND Category = @Category";
            if (status != null)
                sql += " AND Status = @Status";

            sql += " ORDER BY Category, Name";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Text", "%" + text + "%");
                if (category != null)
                    cmd.Parameters.AddWithValue("@Category", category.ToString());
                if (status != null)
                    cmd.Parameters.AddWithValue("@Status", status.ToString());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        items.Add(MapRow(reader));
                }
            }
            return items;
        }
    }
}
