using Microsoft.EntityFrameworkCore;
using TanejaShoeStore.Models;

namespace TanejaShoeStore.Data
{
    public class TanejaShoeStoreContext : DbContext
    {

        public TanejaShoeStoreContext(DbContextOptions<TanejaShoeStoreContext> options)
            : base(options)
        {
        }

      public DbSet<Shoe> Shoe { get; set; }
    }
}
