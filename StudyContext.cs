using Microsoft.EntityFrameworkCore;

namespace To__Do
{
    public class StudyContext : DbContext
    {
        public StudyContext (DbContextOptions options)
           : base(options)
        {

        }
        public DbSet<RegisterDetails>Details { get; set; }
    }
}
