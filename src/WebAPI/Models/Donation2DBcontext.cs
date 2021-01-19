using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class Donation2DBcontext : DbContext
    {
        public Donation2DBcontext(DbContextOptions<Donation2DBcontext> options) : base(options)
        {

        }

        public DbSet<DCandidate> DCandidates { get; set; }

    }
}
