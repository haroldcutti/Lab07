using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BInvoice
    {
        private DInvoice dataInvoice = new DInvoice();

        public List<Invoice> ObtenerFacturas()
        {
            return dataInvoice.GetInvoices();
        }
    }
}