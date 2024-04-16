using TcaSolutions.Data.Interfaces;
using TcaSolutions.Entities;

namespace TcaSolutions.Data.Seeds
{
    public class LoginDefault : ILoginDefault
    {
        private readonly AppDbContext _appDbContext;
        private readonly IAuthenticationRepository _iAuthenticationRepository;
        private readonly IWorkUnit _iWorkUnit;

        public LoginDefault(AppDbContext appDbContext, IAuthenticationRepository iAuthenticationRepository, IWorkUnit iWorkUnit)
        {
            this._appDbContext = appDbContext;
            _iAuthenticationRepository = iAuthenticationRepository;
            this._iWorkUnit = iWorkUnit;
        }

        public async Task CreateDefaultLogin()
        {
            Login login = new Login()
            {
                User = "admin",
                Password = "admin",
                CreatedAt = DateTime.Now.ToUniversalTime(),
            };

            int resultLogin = await LoginExist(login);

            if (resultLogin == 0)
            {
                try
                {
                    _iWorkUnit.BeginTransaction();

                    await _appDbContext.Logins.AddAsync(login);

                    await _iWorkUnit.SaveChangesAsync();

                    await _iWorkUnit.CommitAsync();
                }
                catch (Exception)
                {
                    await _iWorkUnit.RollbackAsync();
                    throw;
                }
            }
        }

        private async Task<int> LoginExist(Login login)
        {
            List<Login> logins = await _iAuthenticationRepository.List(login);

            return logins.Count;
        }
    }
}
