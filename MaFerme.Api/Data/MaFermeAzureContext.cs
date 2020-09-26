using MaFerme.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MaFerme.Api.Data
{
    public class MaFermeAzureContext: IdentityDbContext<ApplicationUser>, IMaFermeContext
    {
        public MaFermeAzureContext(DbContextOptions<MaFermeAzureContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todo { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}