using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmTips2016.Models
{
    public class EmDbContext : DbContext
    {
        
        public DbSet<User> User { get; set; }        
        public DbSet<AdvanceBet> AdvanceBet { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<AdvanceBet>().ToTable("AdvanceBets");
           
        }
    
    }
}
