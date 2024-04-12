using Blog.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure.Data.MSSQL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder _sqlConnectionStringBuilder = new()
            {
                DataSource = ".",
                InitialCatalog = "testDb",
                UserID = "sa",
                Password = "sa@123",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(_sqlConnectionStringBuilder.ConnectionString);
        }

        public DbSet<BlogDataModel> Blogs { get; set; }
    }
}