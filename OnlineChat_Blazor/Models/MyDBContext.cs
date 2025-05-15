using Microsoft.EntityFrameworkCore;

namespace OnlineChat_Blazor.Models
{
    public class MyDBContext : DbContext
    {
       public DbSet<Message> Messages { get; set; }
       public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=LearningDB; Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
