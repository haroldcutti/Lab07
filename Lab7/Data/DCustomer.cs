using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DCustomer
    {
        private string connectionString = "Server=LAB1507-19\\SQLEXPRESS03;Database=master;User Id=Tecsup1;Password=123456789;";

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT customer_id, name, address, phone, active FROM customers";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        CustomerId = (int)reader["customer_id"],
                        Name = reader["name"].ToString(),
                        Address = reader["address"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Active = (bool)reader["active"]
                    };

                    customers.Add(customer);
                }
            }

            return customers;
        }
    }
}