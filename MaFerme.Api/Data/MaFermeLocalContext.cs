using System.Threading.Tasks;
using MaFerme.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaFerme.Api.Data
{
    public class MaFermeLocalContext : IdentityDbContext<ApplicationUser>, IMaFermeContext
    {
        public MaFermeLocalContext (DbContextOptions<MaFermeLocalContext> options)
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
