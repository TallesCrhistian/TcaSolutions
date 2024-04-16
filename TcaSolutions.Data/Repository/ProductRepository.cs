using Microsoft.EntityFrameworkCore;
using TcaSolutions.Data.Interfaces;
using TcaSolutions.Entities;

namespace TcaSolutions.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<List<Product>> List()
        {
            List<Product> products = await this._appDbContext.Products.ToListAsync();

            return products;
        }
    }
}
