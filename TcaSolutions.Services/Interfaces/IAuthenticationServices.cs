using TcaSolutions.Shared.DTOs;
using TcaSolutions.Shared.Enums;
using TcaSolutions.Shared.ViewModels;

namespace TcaSolutions.Services.Interfaces
{
    public interface IAuthenticationServices
    {
        Task<ServiceResponseDTO<EnumLogin>> Login(LoginViewModel loginViewModel);
    }
}