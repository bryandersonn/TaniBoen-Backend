using Microsoft.EntityFrameworkCore;
using TaniBoen.Models.Domain;

namespace TaniBoen.Data
{
    public class TaniBoenData : DbContext
    {
        public TaniBoenData(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RegisData> Register { get; set; }

        public DbSet<ProductData> Product { get; set; }
    }
}
