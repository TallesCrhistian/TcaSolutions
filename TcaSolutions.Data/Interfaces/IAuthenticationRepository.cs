using TcaSolutions.Entities;

namespace TcaSolutions.Data.Interfaces
{
    public interface IAuthenticationRepository
    {
        Task<List<Login>> List(Login login);
    }
}