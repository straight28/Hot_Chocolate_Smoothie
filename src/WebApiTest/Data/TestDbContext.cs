using Microsoft.EntityFrameworkCore;

namespace WebApiTest.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options) { }
        public DbSet<TestClass> TestClasss { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TestClass>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
    }
}
