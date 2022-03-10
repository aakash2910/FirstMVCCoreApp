using Microsoft.EntityFrameworkCore;

namespace FirstMVCCoreApp.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Create table named Categories in DB 
        public DbSet<Category> Categories { get; set; }
    }
}
