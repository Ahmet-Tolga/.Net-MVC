using Microsoft.EntityFrameworkCore;
using ContactFormApp.Models;

namespace ContactFormApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ContactForm> ContactForms { get; set; }
    }
}
