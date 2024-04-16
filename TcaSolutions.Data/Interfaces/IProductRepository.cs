using TcaSolutions.Entities;

namespace TcaSolutions.Data.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> List();
    }
}