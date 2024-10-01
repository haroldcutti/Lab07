using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCustomer
    {
        private DCustomer dataCustomer = new DCustomer();

        public List<Customer> ObtenerClientes()
        {
            return dataCustomer.GetCustomers();
        }
    }
}