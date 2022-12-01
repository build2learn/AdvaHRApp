using Microsoft.Extensions.Configuration;

namespace AdvaEmployeeApp.Models
{
    public class HRDBContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // It's not recommended to be here 
            optionsBuilder.UseSqlServer("TrustServerCertificate=True;Server=172.16.50.10;Database=HRDB;User Id=cmsadmin;password=cmsadmin;");
        }
    }
}
