using AutoMapper;
using TcaSolutions.Business.Interfaces;
using TcaSolutions.Data.Interfaces;
using TcaSolutions.Entities;
using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.Enums;

namespace TcaSolutions.Business
{
    public class AuthenticationBusiness : IAuthenticationBusiness
    {
        private readonly IAuthenticationRepository _iLoginRepository;
        private readonly IMapper _mapper;

        public AuthenticationBusiness(IAuthenticationRepository iLoginRepository, IMapper mapper)
        {
            _iLoginRepository = iLoginRepository;
            _mapper = mapper;
        }

        public async Task<EnumLogin> Login(LoginDTO loginDTO)
        {
            Login login = _mapper.Map<Login>(loginDTO);

            List<Login> results = await _iLoginRepository.List(login);

            if (results.Count > 0)
            {
                return EnumLogin.Authorized;
            }
            else
            {
                return EnumLogin.NotAuthorized;
            }
        }
    }
}
