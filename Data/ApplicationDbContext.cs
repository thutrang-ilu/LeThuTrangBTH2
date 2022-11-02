using LeThuTrangBTH2.Models;
using Microsoft.EntityFrameworkCore;

namespace LeThuTrangBTH2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set;}
        public DbSet<Person> Persons { get; set;}
        public DbSet<LeThuTrangBTH2.Models.Employee> Employees { get; set;}
        public DbSet<Customer> Customers { get; set;}
        public object Employee { get; internal set; }
    }
}