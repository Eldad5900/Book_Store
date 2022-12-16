using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class BookStorDbContext : DbContext
    {
        public BookStorDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=DESKTOP-6S42NQ6;Initial Catalog=BookStore;Integrated Security=True");
            }
        }
        public virtual DbSet<> Books { get; set; }
        public virtual DbSet<> Journals { get; set; }
        public virtual DbSet<> Sales { get; set; }
        public virtual DbSet<> AllStor { get; set; }
    }
}

}