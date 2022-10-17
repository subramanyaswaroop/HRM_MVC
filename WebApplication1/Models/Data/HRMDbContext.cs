using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Data
{
    public class HRMDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HRMDbnew2022;Integrated Security=True");
        }

        public DbSet<EmployeeInfo> Employees { get; set; }
    }
}
