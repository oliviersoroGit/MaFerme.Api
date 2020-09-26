using MaFerme.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MaFerme.Api.Data
{
    public class MaFermeApiContextFactory : IDesignTimeDbContextFactory<MaFermeLocalContext>
    {
        public MaFermeLocalContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MaFermeLocalContext>();
            var connStr = ConfigurationHelper.GetCurrentSettings("ConnectionStrings:MaFermeLocalContext");
            optionsBuilder.UseNpgsql(connStr);
            return new MaFermeLocalContext(optionsBuilder.Options);
        }
    }
}
