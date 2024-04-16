using AutoMapper;
using TcaSolutions.Business.Interfaces;
using TcaSolutions.Data.Interfaces;
using TcaSolutions.Entities;
using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.Exceptions;
using TcaSolutions.Shared.Messages;

namespace TcaSolutions.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository _iBaseRepository;
        private readonly IProductRepository _iProductRepository;

        public ProductBusiness(IMapper mapper, IBaseRepository iBaseRepository, IProductRepository iProductRepository)
        {
            _mapper = mapper;
            _iBaseRepository = iBaseRepository;
            _iProductRepository = iProductRepository;
        }

        public async Task<ProductDTO> Create(ProductDTO productDTO)
        {
            productDTO.CreatedAt = DateTime.Now.ToUniversalTime();

            Product product = _mapper.Map<Product>(productDTO);

            product = await _iBaseRepository.Create(product);

            productDTO = (product is not null) ? _mapper.Map<ProductDTO>(product)
                : throw new CustomException(BadRequestMessages.ProductNoCreate, new HttpRequestException());

            return productDTO;
        }

        public async Task<ProductDTO> Read(Guid id)
        {
            Product product = await _iBaseRepository.Read<Product>(id);

            ProductDTO productDTO = product is not null ? _mapper.Map<ProductDTO>(product)
                : throw new CustomException(NotFoundMessages.Product, new HttpRequestException());

            return productDTO;
        }

        public async Task<ProductDTO> Update(ProductDTO productDTO, Guid id)
        {

            Product product = await _iBaseRepository.Read<Product>(id);

            if (product is not null)
            {
                product = _mapper.Map<Product>(productDTO);

                product.UpdatedAt = DateTime.Now.ToUniversalTime();
                product.Id = id;

                product = await _iBaseRepository.Update(product);

                productDTO = product is not null ? _mapper.Map<ProductDTO>(product)
                    : throw new CustomException(BadRequestMessages.ProductNoUpdate, new HttpRequestException());

                return productDTO;
            }
            else
            {
                throw new CustomException(NotFoundMessages.Product, new HttpRequestException());
            }
        }

        public async Task<ProductDTO> Delete(Guid id)
        {
            Product product = await _iBaseRepository.Read<Product>(id);

            if (product is not null)
            {
                await _iBaseRepository.Delete<Product>(id);
            }
            else
            {
                throw new CustomException(NotFoundMessages.Product, new HttpRequestException());
            }

            ProductDTO productDTO = _mapper.Map<ProductDTO>(product);

            return productDTO;
        }

        public async Task<List<ProductDTO>> List()
        {
            List<Product> products = await _iProductRepository.List();

            List<ProductDTO> producstDTO = products is not null ? _mapper.Map<List<ProductDTO>>(products)
                : throw new CustomException(NotFoundMessages.Product, new HttpRequestException());

            return producstDTO;
        }
    }
}
