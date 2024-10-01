using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BInvoiceDetail
    {
        private DInvoiceDetail dataInvoiceDetail = new DInvoiceDetail();

        public List<InvoiceDetail> ObtenerDetallesFactura()
        {
            return dataInvoiceDetail.GetInvoiceDetails();
        }
    }
}