using Microsoft.EntityFrameworkCore;
using Npgsql;
using TcaSolutions.Entities;
using TcaSolutions.Shared.Enums;

namespace TcaSolutions.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<EnumLogin>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            modelBuilder.HasPostgresEnum<EnumLogin>();
        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
