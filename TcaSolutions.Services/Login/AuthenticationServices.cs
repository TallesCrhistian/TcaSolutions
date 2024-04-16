using AutoMapper;
using TcaSolutions.Business.Interfaces;
using TcaSolutions.Data.Interfaces;
using TcaSolutions.Services.Interfaces;
using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.Enums;
using TcaSolutions.Shared.Exceptions;
using TcaSolutions.Shared.Messages;
using TcaSolutions.Shared.ViewModels;

namespace TcaSolutions.Services.Login
{
    public class AuthenticationServices : IAuthenticationServices
    {
        private readonly IWorkUnit _iWorkUnit;
        private readonly IMapper _mapper;
        private readonly IAuthenticationBusiness _iAuthenticationBusiness;

        public AuthenticationServices(IWorkUnit workUnit, IMapper mapper, IAuthenticationBusiness iAuthenticationBusiness)
        {
            _iWorkUnit = workUnit;
            _mapper = mapper;
            _iAuthenticationBusiness = iAuthenticationBusiness;
        }

        public async Task<ServiceResponseDTO<EnumLogin>> Login(LoginViewModel loginViewModel)
        {
            ServiceResponseDTO<EnumLogin> serviceResponseDTO = new ServiceResponseDTO<EnumLogin>();

            try
            {
                LoginDTO loginDTO = _mapper.Map<LoginDTO>(loginViewModel);

                EnumLogin result = await _iAuthenticationBusiness.Login(loginDTO);

                serviceResponseDTO.GenericData = result;
                serviceResponseDTO.Message = LoginMessage.LoginSuccesfuly;
                serviceResponseDTO.Success = true;              
            }
            catch (CustomException ex)
            {
                this._iWorkUnit.RollbackAsync();

                serviceResponseDTO = CatchCustom.ServiceResponse<CustomException, EnumLogin>(ex);
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
