using System.Data.Entity;

namespace Normirovanie
{
    public class WorkDBContext : DbContext
    {
        public WorkDBContext()
            : base("name=WorkDBContext")

        {
        }
        public DbSet<Work> Works { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}