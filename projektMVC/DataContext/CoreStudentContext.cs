using Microsoft.EntityFrameworkCore;

namespace projektMVC.DataContext
{
    public class CoreStudentsContext : DbContext
    {
        public CoreStudentsContext(DbContextOptions<CoreStudentsContext> options) : base(options)
        {
        }
        public virtual DbSet<projektMVC.Models.Group> Groups { get; set; }
        public virtual DbSet<projektMVC.Models.Student> Students { get; set; }
    }
}

