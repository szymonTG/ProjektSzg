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
        public DbSet<BookRentals> t_BookRentals { get; set; }
        public DbSet<Books> t_Books { get; set; }
        public DbSet<Employees> t_Employees { get; set; }
        public DbSet<Users> t_Users { get; set; }




    }
}