using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace CadClient.Infra.AppDBContext
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=CadClient;trusted_connection=true;trustServerCertificate=True;");

            return new AppDbContext(optionsBuilder.Options);

        }
    }
}
