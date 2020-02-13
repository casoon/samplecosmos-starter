using System;
using Microsoft.EntityFrameworkCore;
using SampleCosmos.Core.Entities;

namespace SampleCosmos.Infrastructure.Data
{

    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
               "*YOUR-COSMOSDB-ENPOINT*",
                "*YOUR-KEY*",
                "EFCoreTest"
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().OwnsOne(j => j.Address);
        }
    }
}
