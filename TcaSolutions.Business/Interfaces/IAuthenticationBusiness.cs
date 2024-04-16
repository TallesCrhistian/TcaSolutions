using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.Enums;

namespace TcaSolutions.Business.Interfaces
{
    public interface IAuthenticationBusiness
    {
        Task<EnumLogin> Login(LoginDTO loginDTO);
    }
}