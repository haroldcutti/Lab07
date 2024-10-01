using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DInvoice
    {
        private string connectionString = "Server=LAB1507-19\\SQLEXPRESS03;Database=master;User Id=Tecsup1;Password=123456789;";

        public List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT invoice_id, customer_id, date, total, active FROM invoices";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Invoice invoice = new Invoice
                    {
                        InvoiceId = (int)reader["invoice_id"],
                        CustomerId = (int)reader["customer_id"],
                        Date = (DateTime)reader["date"],
                        Total = (decimal)reader["total"],
                        Active = (bool)reader["active"]
                    };

                    invoices.Add(invoice);
                }
            }

            return invoices;
        }
    }
}