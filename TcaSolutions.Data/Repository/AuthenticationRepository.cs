using Microsoft.EntityFrameworkCore;
using TcaSolutions.Data.Interfaces;
using TcaSolutions.Entities;

namespace TcaSolutions.Data.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private AppDbContext _appDbContext;

        public AuthenticationRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<List<Login>> List(Login login)
        {
            IQueryable<Login> query = Filters(login);

           List<Login> results = await query.ToListAsync();

            return results;
        }

        private IQueryable<Login> Filters(Login login)
        {
            IQueryable<Login> query = _appDbContext.Logins;

            if (!string.IsNullOrEmpty(login.User))
            {
                query = query.Where(e => e.User == login.User);
            }

            if (!string.IsNullOrEmpty(login.Password))
            {
                query = query.Where(e => e.Password == login.Password);
            }

            return query;
        }
    }
}
