using AT.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AT.Data
{
    public class MainContext : DbContext
    { 
        public MainContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }    
}