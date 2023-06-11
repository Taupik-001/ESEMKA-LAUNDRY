using Microsoft.EntityFrameworkCore;

namespace Test
{
    public class EsemkaContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }

        private static string serverDt = "LOCALHOST\\SQLEXPRESS";
        private static string databaseDt = "ESEMKA2023";

        private static string connectionStringDt = $"Data Source={serverDt};Initial Catalog={databaseDt};Integrated Security=True;TrustServerCertificate=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionStringDt);
        }
    }
}
