using Microsoft.EntityFrameworkCore;
using WebApiUsingMySQL.Models;

namespace WebApiUsingMySQL.Data
{
    public class CustomerDbcontext : DbContext
    {
        public CustomerDbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> customers { get; set; } 
    }
}
