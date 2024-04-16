using System.Windows.Forms;
using TcaSolutions.Entities;
using TcaSolutions.Services.Interfaces;
using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.ViewModels.Product;

namespace TcaSolutions.Forms
{
    public partial class ListProductForm : Form
    {
        private readonly IProductServices _iProductServices;

        public ListProductForm(IProductServices iProductServices)
        {
            _iProductServices = iProductServices;
            InitializeComponent();
            PopulateProductGrid();
        }

        private async void PopulateProductGrid()
        {
            List<ProductViewModel> products = await GetProductsFromDataSource();

            dataGridViewProduct.Rows.Clear();

            AddColumn();

            foreach (ProductViewModel product in products)
            {
                dataGridViewProduct.Rows.Add(product.Name, product.Description, product.Price, product.CostPrice, product.Stock, product.Barcode);
            }

            AdjustColumnWidths();
        }

        private void AddColumn()
        {
            dataGridViewProduct.Columns.Add("Name", "Nome");
            dataGridViewProduct.Columns.Add("Description", "Descrição");
            dataGridViewProduct.Columns.Add("Price", "Preço");
            dataGridViewProduct.Columns.Add("CostPrice", "Preço de Custo");
            dataGridViewProduct.Columns.Add("Stock", "Estoque");
            dataGridViewProduct.Columns.Add("BarCode", "Código de barras");
        }

        private async Task<List<ProductViewModel>> GetProductsFromDataSource()
        {
            ServiceResponseDTO<List<ProductViewModel>> products = await _iProductServices.List();

            return products.GenericData;
        }
        private void AdjustColumnWidths()
        {
            foreach (DataGridViewColumn column in dataGridViewProduct.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
