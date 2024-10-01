using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BProduct
    {
        private DProduct dataProduct = new DProduct();

        public List<Product> ObtenerProductos()
        {
            return dataProduct.GetProducts();
        }
    }
}