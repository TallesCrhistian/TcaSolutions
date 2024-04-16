using System.Windows.Forms;
using TcaSolutions.Services.Interfaces;
using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.ViewModels.Product;

namespace TcaSolutions.Forms
{
    public partial class CreateProductForm : Form
    {
        private readonly IProductServices _iProductServices;
        public CreateProductForm(IProductServices iProductServices)
        {
            _iProductServices = iProductServices;
            InitializeComponent();
        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;*.bmp|Todos os arquivos (*.*)|*.*";
            openFileDialog.Title = "Importar Imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;

                    string targetFolder = Path.Combine(Application.StartupPath, "Imagens");

                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }

                    string fileName = Path.GetFileName(imagePath);
                    string destPath = Path.Combine(targetFolder, fileName);
                    File.Copy(imagePath, destPath, true);

                    pictureBoxProduct.Image = Image.FromFile(destPath);

                    pictureBoxProduct.ImageLocation = destPath;

                    MessageBox.Show("Imagem importada com sucesso para a pasta do projeto.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao importar a imagem: {ex.Message}");
                }
            }
        }

        private async void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            ProductCreateViewModel productCreateViewModel = new ProductCreateViewModel()
            {
                Image = pictureBoxProduct.ImageLocation,
                Barcode = textBoxBarcode.Text,
                CostPrice = ConvertStringToDouble(textBoxCostPrice.Text, "Preço de Custo"),
                CreatedAt = DateTime.Now.ToUniversalTime(),
                Description = textBoxDescription.Text,
                ExpiryDate = dateTimePickerExpiryDate.Value.ToUniversalTime(),
                ManufactureDate = dateTimePickerManufacturerDate.Value.ToUniversalTime(),
                Name = textBoxName.Text,
                Stock = ConvertStringToInt(textBoxStock.Text, "Stoque"),
                Price = ConvertStringToDouble(textBoxPrice.Text, "Preço"),
                Supplier = comboBoxCategory.SelectedIndex.ToString(),
                Category = comboBoxCategory.SelectedIndex.ToString(),
            };

            if (productCreateViewModel.CostPrice == null || productCreateViewModel.Price == null || productCreateViewModel.Stock == null)
            {
                return;
            }
            else
            {
                ServiceResponseDTO<ProductViewModel> serviceResponseDTO = await _iProductServices.Create(productCreateViewModel);

                if (!serviceResponseDTO.Success)
                {
                    MessageBox.Show("Erro ao criar o Produto!");
                }
                else
                {
                    pictureBoxProduct.Image.Dispose();
                    textBoxBarcode.Text = string.Empty;
                    textBoxCostPrice.Text = string.Empty;
                    textBoxDescription.Text = string.Empty;                   
                    textBoxName.Text = string.Empty;
                    textBoxPrice.Text = string.Empty;
                    textBoxStock.Text = string.Empty;
                    textBoxSupplier.Text = string.Empty;
                    comboBoxCategory.SelectedIndex = -1;
                    dateTimePickerExpiryDate.Text = string.Empty;
                    dateTimePickerManufacturerDate.Text = string.Empty;
                }
            }
        }

        private int? ConvertStringToInt(string inputNumber, string inputName)
        {
            int number;

            bool success = int.TryParse(inputNumber, out number);

            if (!success)
            {
                MessageBox.Show($"O campo {inputName} não contém um número inteiro.");
                return null;
            }

            return number;
        }

        private double? ConvertStringToDouble(string inputNumber, string inputName)
        {
            double number;

            bool success = double.TryParse(inputNumber, out number);

            if (!success)
            {
                MessageBox.Show($"O campo {inputName} não contém um número válido.");
                return null;
            }

            return number;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
