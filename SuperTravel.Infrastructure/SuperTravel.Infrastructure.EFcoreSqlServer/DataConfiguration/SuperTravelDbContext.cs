using Microsoft.EntityFrameworkCore;
using SuperTravel.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SuperTravel.Infrastructure.EFcoreSqlServer.DataConfiguration
{
    public class SuperTravelDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public SuperTravelDbContext(DbContextOptions<SuperTravelDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapper());
        }

    }
}
