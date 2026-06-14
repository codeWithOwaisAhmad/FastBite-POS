using FastBite.Core.Contracts;
using FastBite.Core.Models;
using FastBite.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FastBite.Core.Services
{
    public class DBOrderService : IOrderService
    {
        private readonly string _connectionString;

        public DBOrderService(string connectionString)
        {
            _connectionString = connectionString;
        }

        // ─────────────────────────────────────────
        // MAP ROW — maps one Orders row to Order object
        // Does NOT load OrderItems (loaded separately)
        // ─────────────────────────────────────────
        private Order MapRow(SqlDataReader reader)
        {
            return new Order
            {
                Id = reader["Id"].ToString(),
                CustomerId = reader["CustomerId"].ToString(),
                CustomerName = reader["CustomerName"].ToString(),
                OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                Status = Enum.Parse<OrderStatusEnum>(reader["Status"].ToString()),
                PaymentMethod = Enum.Parse<PaymentMethodEnum>(reader["PaymentMethod"].ToString()),
                TotalAmount = Convert.ToDecimal(reader["TotalAmount"])
            };
        }

        // ─────────────────────────────────────────
        // LOAD ORDER ITEMS for a given OrderId
        // Called after loading the Order header
        // ─────────────────────────────────────────
        private List<OrderItem> LoadOrderItems(string orderId, SqlConnection conn)
        {
            List<OrderItem> items = new List<OrderItem>();

            string sql = "SELECT * FROM OrderItems WHERE OrderId = @OrderId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@OrderId", orderId);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    items.Add(new OrderItem
                    {
                        Id           = Convert.ToInt32(reader["Id"]),
                        OrderId      = reader["OrderId"].ToString(),
                        MenuItemId   = reader["MenuItemId"].ToString(),
                        MenuItemName = reader["MenuItemName"].ToString(),
                        UnitPrice    = Convert.ToDecimal(reader["UnitPrice"]),
                        Quantity     = Convert.ToInt32(reader["Quantity"])
                    });
                }
            }

            return items;
        }

        // ─────────────────────────────────────────
        // ADD — inserts Order header + all OrderItems
        // ─────────────────────────────────────────
        void IOrderService.Add(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("Order cannot be null");

            string orderSql =
                "INSERT INTO Orders (Id, CustomerId, CustomerName, OrderDate, Status, PaymentMethod, TotalAmount) " +
                "VALUES (@Id, @CustomerId, @CustomerName, @OrderDate, @Status, @PaymentMethod, @TotalAmount)";

            string itemSql =
                "INSERT INTO OrderItems (OrderId, MenuItemId, MenuItemName, UnitPrice, Quantity) " +
                "VALUES (@OrderId, @MenuItemId, @MenuItemName, @UnitPrice, @Quantity)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Insert order header first

                order.RecalculateTotal();

                SqlCommand orderCmd = new SqlCommand(orderSql, conn);
                orderCmd.Parameters.AddWithValue("@Id",            order.Id);
                orderCmd.Parameters.AddWithValue("@CustomerId",    order.CustomerId);
                orderCmd.Parameters.AddWithValue("@CustomerName",  order.CustomerName);
                orderCmd.Parameters.AddWithValue("@OrderDate",     order.OrderDate);
                orderCmd.Parameters.AddWithValue("@Status",        order.Status.ToString());
                orderCmd.Parameters.AddWithValue("@PaymentMethod", order.PaymentMethod.ToString());
                orderCmd.Parameters.AddWithValue("@TotalAmount",   order.TotalAmount);
                orderCmd.ExecuteNonQuery();

                // Insert each order item
                foreach (OrderItem item in order.Items)
                {
                    SqlCommand itemCmd = new SqlCommand(itemSql, conn);
                    itemCmd.Parameters.AddWithValue("@OrderId",      order.Id);
                    itemCmd.Parameters.AddWithValue("@MenuItemId",   item.MenuItemId);
                    itemCmd.Parameters.AddWithValue("@MenuItemName", item.MenuItemName);
                    itemCmd.Parameters.AddWithValue("@UnitPrice",    item.UnitPrice);
                    itemCmd.Parameters.AddWithValue("@Quantity",     item.Quantity);
                    itemCmd.ExecuteNonQuery();
                }
            }
        }

        // ─────────────────────────────────────────
        // UPDATE — updates Order header
        // OrderItems: delete old ones, insert new ones
        // ─────────────────────────────────────────
        void IOrderService.Update(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("Order cannot be null");

            string orderSql =
                "UPDATE Orders SET CustomerId = @CustomerId, CustomerName = @CustomerName, " +
                "OrderDate = @OrderDate, Status = @Status, " +
                "PaymentMethod = @PaymentMethod, TotalAmount = @TotalAmount " +
                "WHERE Id = @Id";

            string deleteItemsSql = "DELETE FROM OrderItems WHERE OrderId = @OrderId";

            string itemSql =
                "INSERT INTO OrderItems (OrderId, MenuItemId, MenuItemName, UnitPrice, Quantity) " +
                "VALUES (@OrderId, @MenuItemId, @MenuItemName, @UnitPrice, @Quantity)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                order.RecalculateTotal();
                // Update order header
                SqlCommand orderCmd = new SqlCommand(orderSql, conn);
                orderCmd.Parameters.AddWithValue("@Id",            order.Id);
                orderCmd.Parameters.AddWithValue("@CustomerId",    order.CustomerId);
                orderCmd.Parameters.AddWithValue("@CustomerName",  order.CustomerName);
                orderCmd.Parameters.AddWithValue("@OrderDate",     order.OrderDate);
                orderCmd.Parameters.AddWithValue("@Status",        order.Status.ToString());
                orderCmd.Parameters.AddWithValue("@PaymentMethod", order.PaymentMethod.ToString());
                orderCmd.Parameters.AddWithValue("@TotalAmount",   order.TotalAmount);
                orderCmd.ExecuteNonQuery();

                // Delete old items then re-insert
                SqlCommand deleteCmd = new SqlCommand(deleteItemsSql, conn);
                deleteCmd.Parameters.AddWithValue("@OrderId", order.Id);
                deleteCmd.ExecuteNonQuery();

                foreach (OrderItem item in order.Items)
                {
                    SqlCommand itemCmd = new SqlCommand(itemSql, conn);
                    itemCmd.Parameters.AddWithValue("@OrderId",      order.Id);
                    itemCmd.Parameters.AddWithValue("@MenuItemId",   item.MenuItemId);
                    itemCmd.Parameters.AddWithValue("@MenuItemName", item.MenuItemName);
                    itemCmd.Parameters.AddWithValue("@UnitPrice",    item.UnitPrice);
                    itemCmd.Parameters.AddWithValue("@Quantity",     item.Quantity);
                    itemCmd.ExecuteNonQuery();
                }
            }
        }

        // ─────────────────────────────────────────
        // DELETE
        // OrderItems are deleted automatically via ON DELETE CASCADE
        // ─────────────────────────────────────────
        void IOrderService.Delete(string id)
        {
            string sql = "DELETE FROM Orders WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // ─────────────────────────────────────────
        // GET BY ID — loads header + items
        // ─────────────────────────────────────────
        Order IOrderService.GetById(string id)
        {
            string sql = "SELECT * FROM Orders WHERE Id = @Id";
            Order order = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        order = MapRow(reader);
                }

                // Load items using same open connection
                if (order != null)
                    order.Items = LoadOrderItems(order.Id, conn);
            }

            return order;
        }

        // ─────────────────────────────────────────
        // GET ALL — loads all orders (no items, for grid display)
        // ─────────────────────────────────────────
        List<Order> IOrderService.GetAll()
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT * FROM Orders ORDER BY OrderDate DESC";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        orders.Add(MapRow(reader));
                }
            }

            return orders;
        }

        // ─────────────────────────────────────────
        // GET BY STATUS
        // ─────────────────────────────────────────
        List<Order> IOrderService.GetByStatus(OrderStatusEnum status)
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT * FROM Orders WHERE Status = @Status ORDER BY OrderDate DESC";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Status", status.ToString());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        orders.Add(MapRow(reader));
                }
            }

            return orders;
        }

        // ─────────────────────────────────────────
        // GET BY CUSTOMER ID
        // ─────────────────────────────────────────
        List<Order> IOrderService.GetByCustomerId(string customerId)
        {
            List<Order> orders = new List<Order>();
            string sql = "SELECT * FROM Orders WHERE CustomerId = @CustomerId ORDER BY OrderDate DESC";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        orders.Add(MapRow(reader));
                }
            }

            return orders;
        }

        // ─────────────────────────────────────────
        // DASHBOARD — Total Revenue
        // ─────────────────────────────────────────
        decimal IOrderService.GetTotalRevenue()
        {
            string sql = "SELECT ISNULL(SUM(TotalAmount), 0) FROM Orders WHERE Status = 'Completed'";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        // ─────────────────────────────────────────
        // DASHBOARD — Total Orders Count
        // ─────────────────────────────────────────
        int IOrderService.GetTotalOrdersCount()
        {
            string sql = "SELECT COUNT(*) FROM Orders";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // ─────────────────────────────────────────
        // DASHBOARD — Revenue by Category (Bar Chart)
        // Joins OrderItems → MenuItems to get category
        // ─────────────────────────────────────────
        Dictionary<string, decimal> IOrderService.GetRevenueByCategory()
        {
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();

            string sql =
                "SELECT m.Category, SUM(oi.UnitPrice * oi.Quantity) AS Revenue " +
                "FROM OrderItems oi " +
                "INNER JOIN MenuItems m ON oi.MenuItemId = m.Id " +
                "INNER JOIN Orders o   ON oi.OrderId    = o.Id " +
                "WHERE o.Status = 'Completed' " +
                "GROUP BY m.Category " +
                "ORDER BY Revenue DESC";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string category = reader["Category"].ToString();
                        decimal revenue = Convert.ToDecimal(reader["Revenue"]);
                        result[category] = revenue;
                    }
                }
            }

            return result;
        }

        // ─────────────────────────────────────────
        // DASHBOARD — Order Count by Status (Pie Chart)
        // ─────────────────────────────────────────
        Dictionary<string, int> IOrderService.GetOrderCountByStatus()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            string sql =
                "SELECT Status, COUNT(*) AS Total " +
                "FROM Orders " +
                "GROUP BY Status";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["Status"].ToString();
                        int count     = Convert.ToInt32(reader["Total"]);
                        result[status] = count;
                    }
                }
            }

            return result;
        }

        // ─────────────────────────────────────────
        // DASHBOARD — Daily Revenue Last 7 Days (Line Chart)
        // ─────────────────────────────────────────
        Dictionary<string, decimal> IOrderService.GetDailyRevenueLastWeek()
        {
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();

            string sql =
                "SELECT CONVERT(NVARCHAR, OrderDate, 23) AS Day, " +
                "       SUM(TotalAmount) AS Revenue " +
                "FROM Orders " +
                "WHERE Status = 'Completed' " +
                "  AND OrderDate >= DATEADD(day, -6, CAST(GETDATE() AS DATE)) " +
                "GROUP BY CONVERT(NVARCHAR, OrderDate, 23) " +
                "ORDER BY Day";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string day      = reader["Day"].ToString();
                        decimal revenue = Convert.ToDecimal(reader["Revenue"]);
                        result[day]     = revenue;
                    }
                }
            }

            return result;
        }
    }
}
