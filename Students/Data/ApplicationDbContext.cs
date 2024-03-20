using Microsoft.EntityFrameworkCore;
using Students.Models.Entities;
namespace Students.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        

        
         

    }
}
