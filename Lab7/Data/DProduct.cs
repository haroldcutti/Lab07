using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DProduct
    {
        private string connectionString = "Server=LAB1507-19\\SQLEXPRESS03;Database=master;User Id=Tecsup1;Password=123456789;";

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT product_id, name, price, stock, active FROM products";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product
                    {
                        ProductId = (int)reader["product_id"],
                        Name = reader["name"].ToString(),
                        Price = (decimal)reader["price"],
                        Stock = (int)reader["stock"],
                        Active = (bool)reader["active"]
                    };

                    products.Add(product);
                }
            }

            return products;
        }
    }
}