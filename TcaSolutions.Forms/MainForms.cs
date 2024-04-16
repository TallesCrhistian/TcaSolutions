using Microsoft.Extensions.DependencyInjection;
using TcaSolutions.Services.Interfaces;
using TcaSolutions.Shared.ServiceProvider;

namespace TcaSolutions.Forms
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }
        private void pictureBoxCheckout_MouseHover(object sender, EventArgs e)
        {
            pictureBoxCheckout.BackColor = Color.Green;
        }

        private void pictureBoxCheckout_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCheckout.BackColor = Color.FromArgb(35, 107, 142);
        }

        private void pictureBoxProducts_MouseHover(object sender, EventArgs e)
        {
            pictureBoxProducts.BackColor = Color.Green;
        }

        private void pictureBoxProducts_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxProducts.BackColor = Color.FromArgb(35, 107, 142);
        }

        private void pictureBoxProducts_Click(object sender, EventArgs e)
        {
            //CreateProductForm createProductForm = new CreateProductForm(ServiceProviderHolder.ServiceProvider.GetRequiredService<IProductServices>());
            //createProductForm.ShowDialog();          

            ListProductForm listProductForm = new ListProductForm(ServiceProviderHolder.ServiceProvider.GetRequiredService<IProductServices>());
            listProductForm.ShowDialog();
        }

    }
}
