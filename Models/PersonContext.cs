using System;
using Microsoft.EntityFrameworkCore;

namespace swhalley.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext()
        {
        }

        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Address>()
                .Property(a => a.AddressOne)
                .HasColumnName("address_one");

            modelBuilder.Entity<Address>()
                .Property( a => a.AddressTwo)
                .HasColumnName("address_two");


            modelBuilder.Entity<Person>()
                .HasOne(a => a.Address)
                .WithOne(b => b.Person)
                .HasForeignKey<Person>(b => b.ID);

        }
    }
}