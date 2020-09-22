
using Microsoft.EntityFrameworkCore;
using QuizAPI.Models;

namespace QuizAPI.Data
{
    public class FotballLagContext : DbContext 
    {
        public FotballLagContext(DbContextOptions<FotballLagContext> opt) : base(opt)
        {
            
        }

        public DbSet<FotballLag> AlleFotballLag { get; set; }

        public DbSet<FotballKamp> AlleFotballKamper { get; set; }


    }
}