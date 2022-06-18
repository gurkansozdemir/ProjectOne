using Microsoft.EntityFrameworkCore;
using OBS.Core.Entities;

namespace OBS.Repository
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BILISIM002\BILISIM;Database=OBSDatabase;Trusted_Connection=True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
    }
}
