using Microsoft.EntityFrameworkCore;
using Signal.Model;

namespace Signal.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) :base(options) { }

        public DbSet<TesterChat> TesterChats { get; set; }
        public DbSet<Tester> Testers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TesterChat>(entity =>
            {
                entity.HasKey(t => t.Id);
            });

            modelBuilder.Entity<Tester>(entity =>
            {
                entity.HasKey(t => t.Id);
            });


        }
    }
}
