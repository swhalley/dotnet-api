using Microsoft.EntityFrameworkCore;

namespace dotnet_api_oauth.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}