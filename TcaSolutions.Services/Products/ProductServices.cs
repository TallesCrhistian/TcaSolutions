using AutoMapper;
using TcaSolutions.Business.Interfaces;
using TcaSolutions.Data;
using TcaSolutions.Data.Interfaces;
using TcaSolutions.Services.Interfaces;
using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.Exceptions;
using TcaSolutions.Shared.Messages;
using TcaSolutions.Shared.ViewModels.Product;

namespace TcaSolutions.Services.Products
{
    public class ProductServices : IProductServices
    {
        private readonly IWorkUnit _iWorkUnit;
        private readonly IMapper _mapper;
        private readonly IProductBusiness _iProductBusiness;

        public ProductServices(IWorkUnit workUnit, IMapper mapper, IProductBusiness iProductBusiness)
        {
            _iWorkUnit = workUnit;
            _mapper = mapper;
            _iProductBusiness = iProductBusiness;
        }

        public async Task<ServiceResponseDTO<ProductViewModel>> Create(ProductCreateViewModel productCreateViewModel)
        {
            ServiceResponseDTO<ProductViewModel> serviceResponseDTO = new ServiceResponseDTO<ProductViewModel>();

            try
            {
                ProductDTO productDTO = _mapper.Map<ProductDTO>(productCreateViewModel);
                productDTO = await _iProductBusiness.Create(productDTO);

                serviceResponseDTO.GenericData = _mapper.Map<ProductViewModel>(productDTO);
                serviceResponseDTO.Message = CreateMessages.Product;
                serviceResponseDTO.Success = true;

                await _iWorkUnit.SaveChangesAsync();

                await _iWorkUnit.CommitAsync();
            }
            catch (CustomException ex)
            {
                await _iWorkUnit.RollbackAsync();

                serviceResponseDTO = CatchCustom.ServiceResponse<CustomException, ProductViewModel>(ex);
            }
            catch (Exception ex)
            {
                await _iWorkUnit.RollbackAsync();

                serviceResponseDTO.Success = false;
                serviceResponseDTO.Message = ex.Message;
            }

            return serviceResponseDTO;
        }


        public async Task<ServiceResponseDTO<ProductViewModel>> Read(Guid id)
        {
            ServiceResponseDTO<ProductViewModel> serviceResponseDTO = new ServiceResponseDTO<ProductViewModel>();

            try
            {
                ProductDTO productDTO = await _iProductBusiness.Read(id);

                serviceResponseDTO.GenericData = _mapper.Map<ProductViewModel>(productDTO);
                serviceResponseDTO.Message = OkMessages.OkMessage;
                serviceResponseDTO.Success = true;

            }
            catch (CustomException ex)
            {
                this._iWorkUnit.RollbackAsync();

                serviceResponseDTO = CatchCustom.ServiceResponse<CustomException, ProductViewModel>(ex);
            }
            catch (Exception ex)
            {
                _iWorkUnit.RollbackAsync();

                serviceResponseDTO.Success = false;
                serviceResponseDTO.Message = ex.Message;
            }

            return serviceResponseDTO;
        }

        public async Task<ServiceResponseDTO<ProductViewModel>> Update(ProductUpdateViewModel productUpdateViewModel, Guid id)
        {
            ServiceResponseDTO<ProductViewModel> serviceResponseDTO = new ServiceResponseDTO<ProductViewModel>();

            try
            {
                ProductDTO productDTO = _mapper.Map<ProductDTO>(productUpdateViewModel);
                productDTO = await _iProductBusiness.Update(productDTO, id);

                serviceResponseDTO.GenericData = _mapper.Map<ProductViewModel>(productDTO);
                serviceResponseDTO.Success = true;

                await _iWorkUnit.SaveChangesAsync();
                await _iWorkUnit.CommitAsync();
            }
            catch (CustomException ex)
            {
                this._iWorkUnit.RollbackAsync();

                serviceResponseDTO = CatchCustom.ServiceResponse<CustomException, ProductViewModel>(ex);
            }
            catch (Exception ex)
            {
                _iWorkUnit.RollbackAsync();

                serviceResponseDTO.Success = false;
                serviceResponseDTO.Message = ex.Message;
            }

            return serviceResponseDTO;
        }

        public async Task<ServiceResponseDTO<ProductViewModel>> Delete(Guid id)
        {
            ServiceResponseDTO<ProductViewModel> serviceResponseDTO = new ServiceResponseDTO<ProductViewModel>();

            try
            {
                ProductDTO productDTO = await _iProductBusiness.Delete(id);

                serviceResponseDTO.GenericData = _mapper.Map<ProductViewModel>(productDTO);
                serviceResponseDTO.Message = OkMessages.OkMessage;
                serviceResponseDTO.Success = true;

                await _iWorkUnit.SaveChangesAsync();
                await _iWorkUnit.CommitAsync();
            }
            catch (CustomException ex)
            {
                this._iWorkUnit.RollbackAsync();

                serviceResponseDTO = CatchCustom.ServiceResponse<CustomException, ProductViewModel>(ex);
            }
            catch (Exception ex)
            {
                _iWorkUnit.RollbackAsync();

                serviceResponseDTO.Success = false;
                serviceResponseDTO.Message = ex.Message;
            }

            return serviceResponseDTO;
        }

        public async Task<ServiceResponseDTO<List<ProductViewModel>>> List()
        {
            ServiceResponseDTO<List<ProductViewModel>> serviceResponseDTO = new ServiceResponseDTO<List<ProductViewModel>>();

            try
            {
                List<ProductDTO> productDTO = await _iProductBusiness.List();

                serviceResponseDTO.GenericData = _mapper.Map<List<ProductViewModel>>(productDTO);
                serviceResponseDTO.Message = OkMessages.OkMessage;
                serviceResponseDTO.Success = true;

            }
            catch (CustomException ex)
            {
                this._iWorkUnit.RollbackAsync();

                serviceResponseDTO = CatchCustom.ServiceResponse<CustomException, List<ProductViewModel>>(ex);
            }
            catch (Exception ex)
            {
                _iWorkUnit.RollbackAsync();

                serviceResponseDTO.Success = false;
                serviceResponseDTO.Message = ex.Message;
            }

            return serviceResponseDTO;
        }
    }
}
