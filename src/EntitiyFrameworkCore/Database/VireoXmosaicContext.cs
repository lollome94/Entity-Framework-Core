using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class VireoXmosaicContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Substation> Substations { get; set; }

        public VireoXmosaicContext(DbContextOptions<VireoXmosaicContext> options) : base(options)
        {


        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant>().ToTable("Plant");
        }
        





    }
}
