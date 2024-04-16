using TcaSolutions.Shared.DTOs;

namespace TcaSolutions.Business.Interfaces
{
    public interface IProductBusiness
    {
        Task<ProductDTO> Create(ProductDTO productDTO);
        Task<ProductDTO> Delete(Guid id);
        Task<ProductDTO> Read(Guid id);
        Task<ProductDTO> Update(ProductDTO productDTO, Guid id);

        Task<List<ProductDTO>> List();
    }
}