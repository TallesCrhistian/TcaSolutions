using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.ViewModels.Product;

namespace TcaSolutions.Services.Interfaces
{
    public interface IProductServices
    {
        Task<ServiceResponseDTO<ProductViewModel>> Create(ProductCreateViewModel productCreateViewModel);
        Task<ServiceResponseDTO<ProductViewModel>> Delete(Guid id);
        Task<ServiceResponseDTO<ProductViewModel>> Read(Guid id);
        Task<ServiceResponseDTO<ProductViewModel>> Update(ProductUpdateViewModel productUpdateViewModel, Guid id);
        Task<ServiceResponseDTO<List<ProductViewModel>>> List();
    }
}