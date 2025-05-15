using GymMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GymMVC.Contexts
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=GymProgram;Trusted_Connection=True;TrustServerCertificate=True";
        public DbSet<ChooseProgram> ChoosePograms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
