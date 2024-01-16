using Microsoft.EntityFrameworkCore;
using RecycleCoinBlockExplorer.Models.Entity;

namespace RecycleCoinBlockExplorer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Atik> Atiklar => Set<Atik>();
        public DbSet<Kisi> Kisiler => Set<Kisi>();
    }
}
