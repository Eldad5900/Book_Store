using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dill
{
    internal class BookStorDbContext : DbContext
    {

    }
}
    
    //    public BookStorDbContext()
    //    {

    //    }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        if (!optionsBuilder.IsConfigured)
    //        {

    //            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=DESKTOP-6S42NQ6;Initial Catalog=BookStore;Integrated Security=True");
    //        }
    //    }
    //    public virtual DbSet<Book> Books { get; set; }
    //    public virtual DbSet<Journal> Journals { get; set; }
    //    public virtual DbSet<ProductItem> Sales { get; set; }
    //    public virtual DbSet<ProductItem> AllStor { get; set; }
    //}

