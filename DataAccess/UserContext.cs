using DataAccess.Models;
using System.Data.Entity;

namespace DataAccess
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext() : base(nameOrConnectionString: "Default") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
