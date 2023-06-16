using Microsoft.EntityFrameworkCore;

namespace Test
{
    public class EsemkaContext : DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<DetailDeposit>? DetailDeposits { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<HeaderDeposit>? HeaderDeposits { get; set; }
        public DbSet<Job>? Jobs { get; set; }
        public DbSet<Package>? Packages { get; set; }
        public DbSet<PrepaidPackage>? PrepaidPackages { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<Unit>? Units { get; set; }


        private static string serverDt = "LOCALHOST\\SQLEXPRESS";
        private static string databaseDt = "ESEMKA2023";

        private static string connectionStringDt = $"Data Source={serverDt};Initial Catalog={databaseDt};Integrated Security=True;TrustServerCertificate=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionStringDt);
        }
    }
}
