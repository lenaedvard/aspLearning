using aspLearning.Enteties;
using Microsoft.EntityFrameworkCore;

namespace aspLearning.Context
{
    public class MyContext(DbContextOptions<MyContext> Options) : DbContext(Options)
    {
        public DbSet<Course> Courses { get; set; }

    }
}
