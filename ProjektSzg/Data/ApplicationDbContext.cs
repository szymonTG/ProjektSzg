using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjektSzg.Models;

namespace ProjektSzg.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<BookRentals> TableBookRentals { get; set; }
        public DbSet<Books> TableBooks { get; set; }
        public DbSet<Employees> TableEmployees { get; set; }
        public DbSet<Users> TableUsers { get; set; }

    }
}