using Microsoft.EntityFrameworkCore;
using TaniBoen.Models.Domain;

namespace TaniBoen.Data
{
    public class TaniBoenData : DbContext
    {
        public TaniBoenData(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
