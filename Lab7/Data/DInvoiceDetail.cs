using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DInvoiceDetail
    {
        private string connectionString = "Server=LAB1507-19\\SQLEXPRESS03;Database=master;User Id=Tecsup1;Password=123456789;";

        public List<InvoiceDetail> GetInvoiceDetails()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT detail_id, invoice_id, product_id, quantity, price, subtotal, active FROM invoice_details";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    InvoiceDetail detail = new InvoiceDetail
                    {
                        DetailId = (int)reader["detail_id"],
                        InvoiceId = (int)reader["invoice_id"],
                        ProductId = (int)reader["product_id"],
                        Quantity = (int)reader["quantity"],
                        Price = (decimal)reader["price"],
                        Subtotal = (decimal)reader["subtotal"],
                        Active = (bool)reader["active"]
                    };

                    invoiceDetails.Add(detail);
                }
            }

            return invoiceDetails;
        }
    }
}