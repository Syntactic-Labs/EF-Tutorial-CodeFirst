using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDbLib.Models
{
    public class AppDbContext : DbContext
    {
        //DbSets go here
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        //fluent api
        protected override void OnModelCreating(ModelBuilder builder)
        {   //entity specifies what you are doing your fluent api on
            builder.Entity<Customer>(e =>
            {   //makes Code in the Customer class/table Unique
                e.HasIndex(p => p.Code).IsUnique(true);
                //Fluent api overrides Attributes... below is an example of setting max length and can not be true alt over Attribute way
                //e.Property(p => p.Name).HasMaxLength(30).IsRequired(true);
            });
        }

        //setting up AppDbContext
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {}
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                var connStr = "server=localhost\\sqlexpress;database=EfSalesDb;trusted_connection=true;";
                builder.UseSqlServer(connStr);
            } 
        }
        
    }
}
