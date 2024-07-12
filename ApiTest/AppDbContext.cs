using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiTest
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Pallet> Pallet { get; set; }

        public DbSet<Order> Order { get; set; }



    }
}
