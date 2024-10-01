using Business;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7
{
    public partial class MainWindow : Window
    {
        private BCustomer bCustomer = new BCustomer();
        private BProduct bProduct = new BProduct();
        private BInvoice bInvoice = new BInvoice();
        private BInvoiceDetail bInvoiceDetail = new BInvoiceDetail();

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvCustomers.ItemsSource = bCustomer.ObtenerClientes();
            dgvProducts.ItemsSource = bProduct.ObtenerProductos();
            dgvInvoices.ItemsSource = bInvoice.ObtenerFacturas();
            dgvInvoiceDetails.ItemsSource = bInvoiceDetail.ObtenerDetallesFactura();
        }
    }
}