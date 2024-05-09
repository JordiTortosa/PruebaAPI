using Microsoft.EntityFrameworkCore;
using TestAPI.Entities;

namespace TestAPI
{
    public class MyDBContext:DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<TypeUser> TypeUsers { get; set; }
        public DbSet<Projects> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(options =>
            {
                options.ToTable("Users");
            });
            modelBuilder.Entity<TypeUser>(options =>
            {
                options.ToTable("TypeUser");
            });
            modelBuilder.Entity<Projects>(options =>
            {
                options.ToTable("Projects");
            });
        }
    }
}
