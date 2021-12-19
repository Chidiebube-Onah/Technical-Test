using Microsoft.EntityFrameworkCore;

namespace Task2.Models.Entities
{
    public class Task2Context : DbContext
    {
        public Task2Context(DbContextOptions<Task2Context> options)
        :base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetail> CountryDetails { get; set; }
    }
}
