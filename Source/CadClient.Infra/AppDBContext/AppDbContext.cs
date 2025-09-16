using Microsoft.EntityFrameworkCore;
using CadClient.Domain.Entities;

namespace CadClient.Infra.AppDBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}
